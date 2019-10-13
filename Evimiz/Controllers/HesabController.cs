using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Evimiz.Controllers
{
    public class HesabController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        //private readonly RoleManager<İstifadəçi> _roleManager;

        public HesabController(Db_Evimiz context,
                               UserManager<ApplicationUser> usermanager,
                               IConfiguration configuration,
                               SignInManager<ApplicationUser> signInManager,
                               IHostingEnvironment env
                             /*  RoleManager<İstifadəçi> roleManager*/)
        {
            _context = context;
            _usermanager = usermanager;
            _configuration = configuration;
            _signInManager = signInManager;
            _env = env;
            //_roleManager = roleManager;
        }

        public IActionResult Seçim()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DaxilOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> DaxilOl(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModel);
            }

            ApplicationUser user = await _usermanager.FindByEmailAsync(loginViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu adlı istifadəçi yoxdur");
                return View(loginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModel);
            }

            return RedirectToAction("AnaSəhifə", "Evimiz");
        }

        [HttpGet]
        public IActionResult Qeydiyat(string userrole)
        {
            ViewBag.NumberKeyCode = _context.NumberKeyCodes.ToList();
            ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();
            if (userrole == "İstifadəçi")
            {
                ViewBag.User = "User";
            }

            else if (userrole == "Əmlakçı")
            {
                ViewBag.Agent = "Agent";
                ViewBag.Regions = _context.Regions.ToList();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Qeydiyat(RegisterViewModel registerViewModel, string userrole)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.NumberKeyCode = _context.NumberKeyCodes.ToList();
                ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();

                if (userrole == "İstifadəçi")
                {
                    ViewBag.User = "User";
                }
                else if (userrole == "Əmlakçı")
                {
                    ViewBag.Agent = "Agent";
                    ViewBag.Cities = _context.Cities.ToList();
                    ViewBag.Regions = _context.Regions.ToList();
                }

                ModelState.AddModelError("", "Xahiş edirik düzgün dəyərlər daxil edəsiniz");
                return View(registerViewModel);
            }

            ApplicationUser user = new ApplicationUser()
            {
                Firstname = registerViewModel.Firstname,
                Lastname = registerViewModel.Lastname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username,
                NumberKeyCodeId = registerViewModel.NumberKeyCodeId,
                NumberKeyCodeSecondId = registerViewModel.NumberKeyCodeSecondId,
                PhoneNumber = registerViewModel.PhoneNumber,
                SecondPhonenumber = registerViewModel.SecondPhonenumber,
                Agencyabout = registerViewModel.Agencyabout,
                RegionId = registerViewModel.RegionId,
                RegisterDate = DateTime.Now,
            };

            if (userrole == "İstifadəçi")
            {
                if (registerViewModel.UserPhoto != null)
                {
                    user.İsUser = true;
                    if (registerViewModel.UserPhoto.ContentType.Contains("image/jpg")
                    || registerViewModel.UserPhoto.ContentType.Contains("image/jpeg"))
                    {
                        string folderPath = Path.Combine(_env.WebRootPath, "images", "profile");
                        string fileName = Guid.NewGuid().ToString() + "_" + registerViewModel.UserPhoto.FileName;
                        string filePath = Path.Combine(folderPath, fileName);

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await registerViewModel.UserPhoto.CopyToAsync(fileStream);
                        }

                        user.UserImageUrl = fileName;
                    }
                }
            }
            else if (userrole == "Əmlakçı")
            {
                if (registerViewModel.AgencyPhoto != null)
                {
                    user.İsAgent = true;
                    if (registerViewModel.AgencyPhoto.ContentType.Contains("image/jpg")
                    || registerViewModel.AgencyPhoto.ContentType.Contains("image/jpeg"))
                    {
                        string folderPath = Path.Combine(_env.WebRootPath, "images", "Agent");
                        string fileName = Guid.NewGuid().ToString() + "_" + registerViewModel.AgencyPhoto.FileName;
                        string filePath = Path.Combine(folderPath, fileName);

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await registerViewModel.AgencyPhoto.CopyToAsync(fileStream);
                        }

                        user.AgencyImageUrl = fileName;
                    }
                }
            }

            IdentityResult result = await _usermanager.CreateAsync(user, registerViewModel.Password);

            if (!result.Succeeded)
            {

                ViewBag.NumberKeyCode = _context.NumberKeyCodes.ToList();
                ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS.ToList();

                if (userrole == "İstifadəçi")
                {
                    ViewBag.User = "User";
                }
                else if (userrole == "Əmlakçı")
                {
                    ViewBag.Agent = "Agent";
                    ViewBag.Regions = _context.Regions.ToList();
                }

                ModelState.AddModelError(" ", "Xahiş edirik düzgün dəyərlər daxil edəsiniz");
                return View(registerViewModel);
            }
            else
            {
                if (userrole == "İstifadəçi")
                {
                    //Add Admin from here
                    //await _usermanager.AddToRoleAsync(user, "Admin");

                    await _usermanager.AddToRoleAsync(user, "Istifadəçi");
                }
                else if (userrole == "Əmlakçı")
                {
                    await _usermanager.AddToRoleAsync(user, "Əmlakçı");
                }
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"],
                                                    _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("insinekuliziader@gmail.com", registerViewModel.Email);
            message.IsBodyHtml = true;
            message.Subject = "Hesabın təsdiqlənməsi";
            message.Body = $"<a href='https://localhost:44346/Hesab/EmailYoxlanışı?id={user.Id}'>Xahiş edirik hesabınızı təsdiqləyəsiniz</a>";
            client.Send(message);

            return RedirectToAction("DaxilOl", "Hesab");
        }

        public async Task<IActionResult> EmailYoxlanışı(string id)
        {
            if (id != null)
            {
                ApplicationUser user = await _usermanager.FindByIdAsync(id);

                if (user != null)
                {
                    user.EmailConfirmed = true;
                    TempData["EmailConfirmed"] = true;
                    await _context.SaveChangesAsync();
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Çıxış()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("AnaSəhifə", "Evimiz");
        }

        [HttpGet]
        public IActionResult Şifrəniunutmuşam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Şifrəniunutmuşam(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(forgetPasswordViewModel);
            }

            ApplicationUser user = await _usermanager.FindByEmailAsync(forgetPasswordViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu email  qeydiyyatdan keçirilməyib!");
                return View(forgetPasswordViewModel);
            }

            string passwordResetToken = await _usermanager.GeneratePasswordResetTokenAsync(user);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(_configuration["ConnectionsStrings:SmtpClientCredentialEmail"],
                                                    _configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            MailMessage message = new MailMessage("insinekuliziader@gmail.com", forgetPasswordViewModel.Email);
            message.IsBodyHtml = true;
            message.Subject = "Hesabın təsdiqlənməsi";
            message.Body = $"<a href='https://localhost:44346/Hesab/Şifrəniyenilə?userId={user.Id}&passwordResetToken={passwordResetToken}'>Hesabınızı pərpa edin</a>";
            client.Send(message);

            TempData["ForgotPassword"] = true;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Şifrəniyenilə(string userId, string passwordResetToken)
        {
            //As Tokens often are generated with "+" and come from query parameter with spaces we have to replace spaces with "+"
            string replacedPasswordResetToken = passwordResetToken.Replace(" ", "+");

            ViewBag.UserId = userId;
            ViewBag.PasswordResetToken = replacedPasswordResetToken;
            if (passwordResetToken == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return View("Views/Evimiz/Error.cshtml");
            }

            ApplicationUser customUserFromDb = await _usermanager.FindByIdAsync(userId);

            if (customUserFromDb == null)
            {
                ViewBag.UserId = userId;
                ViewBag.PasswordResetToken = replacedPasswordResetToken;
                return View("Views/Evimiz/Error.cshtml");
            }

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Şifrəniyenilə(ResetAndSetNewPasswordViewModel resetAndSetNewPasswordViewModel)
        {

            ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
            ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
            ApplicationUser customUserFromDb = await _usermanager.FindByIdAsync(resetAndSetNewPasswordViewModel.UserId);

            if (!ModelState.IsValid)
            {
                ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
                ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
                return View(resetAndSetNewPasswordViewModel);
            }

            IdentityResult result = await _usermanager.ResetPasswordAsync(customUserFromDb, resetAndSetNewPasswordViewModel.PasswordResetToken, resetAndSetNewPasswordViewModel.NewPassword);

            if (!result.Succeeded)
            {
                ViewBag.UserId = resetAndSetNewPasswordViewModel.UserId;
                ViewBag.PasswordResetToken = resetAndSetNewPasswordViewModel.PasswordResetToken;
                ModelState.AddModelError("", "Daxil etdiyiniz şifrə tələblərə uyğun deyil.");
                return View(resetAndSetNewPasswordViewModel);
            }

            await _usermanager.UpdateAsync(customUserFromDb);
            TempData["AccountRestored"] = true;
            return RedirectToAction("DaxilOl", "Hesab");
        }

        [HttpGet]
        public async  Task<IActionResult> UserDüzəlişEt()
        {
            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            ViewBag.FirstName = user.Firstname;
            ViewBag.LastName = user.Lastname;
            ViewBag.Email = user.Email;

            ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
            ViewBag.PhoneNumber = user.PhoneNumber;
            ViewBag.NumberKeyCode = _context.NumberKeyCodes;

            ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
            ViewBag.SecondPhonenumber = user.SecondPhonenumber;
            ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

            ViewBag.UserImageUrl =user.UserImageUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserDüzəlişEt(EditUserPRofileViewModel editUserPRofileViewModel)
        {
            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewBag.FirstName = user.Firstname;
                ViewBag.LastName = user.Lastname;
                ViewBag.Email = user.Email;

                ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                ViewBag.PhoneNumber = user.PhoneNumber;
                ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                ViewBag.UserImageUrl = user.UserImageUrl;
                return View(editUserPRofileViewModel);
            }

            user.Firstname = editUserPRofileViewModel.Firstname;
            user.Lastname = editUserPRofileViewModel.Lastname;
            user.Email = editUserPRofileViewModel.Email;
            user.NumberKeyCodeId = editUserPRofileViewModel.NumberKeyCodeId;
            user.PhoneNumber = editUserPRofileViewModel.PhoneNumber;
            
            user.NumberKeyCodeSecondId = editUserPRofileViewModel.NumberKeyCodeSecondId;
            user.SecondPhonenumber = editUserPRofileViewModel.SecondPhonenumber;
            
            user.EmailConfirmed = true;

            await _usermanager.UpdateAsync(user);

            if (editUserPRofileViewModel.CurrentPassword != null && editUserPRofileViewModel.NewPassword != null)
            {
                string replacedCurrentPassword = editUserPRofileViewModel.CurrentPassword;
                string replacedNewPassword = editUserPRofileViewModel.NewPassword;

                IdentityResult result = await _usermanager.ChangePasswordAsync(user, replacedCurrentPassword, replacedNewPassword);
                await _usermanager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    ViewBag.FirstName = user.Firstname;
                    ViewBag.LastName = user.Lastname;
                    ViewBag.Email = user.Email;

                    ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                    ViewBag.PhoneNumber = user.PhoneNumber;
                    ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                    ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                    ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                    ViewBag.UserImageUrl = user.UserImageUrl;

                    ModelState.AddModelError("CurrentPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    ModelState.AddModelError("NewPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    return View(editUserPRofileViewModel);
                }
            }

            if (editUserPRofileViewModel.UserPhoto != null)
            {
                if (editUserPRofileViewModel.UserPhoto.ContentType.Contains("image/jpg")
                || editUserPRofileViewModel.UserPhoto.ContentType.Contains("image/jpeg"))
                {
                    if (editUserPRofileViewModel.UserPhoto.Length > (2 * 1024 * 1024))
                    {
                        ViewBag.FirstName = user.Firstname;
                        ViewBag.LastName = user.Lastname;
                        ViewBag.Email = user.Email;

                        ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                        ViewBag.PhoneNumber = user.PhoneNumber;
                        ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                        ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                        ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                        ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;
                        ViewBag.UserImageUrl = user.UserImageUrl;
                        ModelState.AddModelError("", "Şəklin həcmi 2MB'dan çox ola bilməz.");
                        return View(editUserPRofileViewModel);
                    }

                    string folderPath = Path.Combine(_env.WebRootPath, "Images", "profile");
                    string fileName = Guid.NewGuid().ToString() + "_" + editUserPRofileViewModel.UserPhoto.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await editUserPRofileViewModel.UserPhoto.CopyToAsync(fileStream);
                    } 

                    //Deleting profile picture of the user from file system
                    string currentFilePath = Path.Combine(_env.WebRootPath, "Images", "profile", user.UserImageUrl);
                    if (System.IO.File.Exists(currentFilePath))
                    {
                        System.IO.File.Delete(currentFilePath);
                    }

                    user.UserImageUrl = fileName;
                    
                    await _context.SaveChangesAsync() ;
                }
                else
                {
                    ViewBag.FirstName = user.Firstname;
                    ViewBag.LastName = user.Lastname;
                    ViewBag.Email = user.Email;

                    ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                    ViewBag.PhoneNumber = user.PhoneNumber;
                    ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                    ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                    ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                    ModelState.AddModelError("", "Zəhmət olmasa, tələb olunan formatda şəkil yükləyin");
                    return View(editUserPRofileViewModel);
                }
            }

            await _usermanager.UpdateAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("AnaSəhifə", "Evimiz"); ;
        }

        [HttpGet]
        public async Task<IActionResult> ƏmlakçıDüzəlişEt()
        {
            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            ViewBag.FirstName = user.Firstname;
            ViewBag.Email = user.Email;

            ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
            ViewBag.PhoneNumber = user.PhoneNumber;
            ViewBag.NumberKeyCode = _context.NumberKeyCodes;

            ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
            ViewBag.SecondPhonenumber = user.SecondPhonenumber;
            ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

            ViewBag.RegionId = user.RegionId;
            ViewBag.Regions = _context.Regions;
            ViewBag.Agencyabout = user.Agencyabout;

            ViewBag.AgencyImageUrl = user.AgencyImageUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ƏmlakçıDüzəlişEt(EditAgentPRofileViewModel editAgentPRofileViewModel)
        {
            ApplicationUser user = await _usermanager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewBag.FirstName = user.Firstname;
                ViewBag.Email = user.Email;

                ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                ViewBag.PhoneNumber = user.PhoneNumber;
                ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                ViewBag.RegionId = user.RegionId;
                ViewBag.Regions = _context.Regions;
                ViewBag.Agencyabout = user.Agencyabout;

                ViewBag.AgencyImageUrl = user.AgencyImageUrl;
                return View(editAgentPRofileViewModel);
            }

            user.Firstname = editAgentPRofileViewModel.Firstname;
            user.Email = editAgentPRofileViewModel.Email;
            user.NumberKeyCodeId = editAgentPRofileViewModel.NumberKeyCodeId;
            user.PhoneNumber = editAgentPRofileViewModel.PhoneNumber;
            user.Agencyabout = editAgentPRofileViewModel.Agencyabout;
            user.RegionId = editAgentPRofileViewModel.RegionId;

            user.NumberKeyCodeSecondId = editAgentPRofileViewModel.NumberKeyCodeSecondId;
            user.SecondPhonenumber = editAgentPRofileViewModel.SecondPhonenumber;

            user.EmailConfirmed = true;

            await _usermanager.UpdateAsync(user);

            if (editAgentPRofileViewModel.CurrentPassword != null && editAgentPRofileViewModel.NewPassword != null)
            {
                string replacedCurrentPassword = editAgentPRofileViewModel.CurrentPassword;
                string replacedNewPassword = editAgentPRofileViewModel.NewPassword;

                IdentityResult result = await _usermanager.ChangePasswordAsync(user, replacedCurrentPassword, replacedNewPassword);
                await _usermanager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    ViewBag.FirstName = user.Firstname;
                    ViewBag.Email = user.Email;

                    ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                    ViewBag.PhoneNumber = user.PhoneNumber;
                    ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                    ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                    ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                    ViewBag.RegionId = user.RegionId;
                    ViewBag.Regions = _context.Regions;
                    ViewBag.Agencyabout = user.Agencyabout;

                    ViewBag.AgencyImageUrl = user.AgencyImageUrl;

                    ModelState.AddModelError("CurrentPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    ModelState.AddModelError("NewPassword", "Hazırki şifrə yanlışdır və ya yeni şifrə tələblərə uyğun deyil.");
                    return View(editAgentPRofileViewModel);
                }
            }

            if (editAgentPRofileViewModel.AgencyPhoto != null)
            {
                if (editAgentPRofileViewModel.AgencyPhoto.ContentType.Contains("image/jpg")
                || editAgentPRofileViewModel.AgencyPhoto.ContentType.Contains("image/jpeg"))
                {
                    if (editAgentPRofileViewModel.AgencyPhoto.Length > (2 * 1024 * 1024))
                    {
                        ViewBag.FirstName = user.Firstname;
                        ViewBag.Email = user.Email;

                        ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                        ViewBag.PhoneNumber = user.PhoneNumber;
                        ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                        ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                        ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                        ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                        ViewBag.RegionId = user.RegionId;
                        ViewBag.Regions = _context.Regions;
                        ViewBag.Agencyabout = user.Agencyabout;

                        ViewBag.AgencyImageUrl = user.AgencyImageUrl;
                        ModelState.AddModelError("", "Şəklin həcmi 2MB'dan çox ola bilməz.");
                        return View(editAgentPRofileViewModel);
                    }

                    string folderPath = Path.Combine(_env.WebRootPath, "Images", "Agent");
                    string fileName = Guid.NewGuid().ToString() + "_" + editAgentPRofileViewModel.AgencyPhoto.FileName;
                    string filePath = Path.Combine(folderPath, fileName);

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await editAgentPRofileViewModel.AgencyPhoto.CopyToAsync(fileStream);
                    }

                    if (user.AgencyImageUrl != null)
                    {
                        string currentFilePath = Path.Combine(_env.WebRootPath, "Images", "Agent", user.AgencyImageUrl);
                        if (System.IO.File.Exists(currentFilePath))
                        {
                            System.IO.File.Delete(currentFilePath);
                        }
                    }

                    
                    user.AgencyImageUrl = fileName;

                    await _context.SaveChangesAsync();
                }
                else
                {
                    ViewBag.FirstName = user.Firstname;
                    ViewBag.Email = user.Email;

                    ViewBag.NumberKeyCodeId = user.NumberKeyCodeId;
                    ViewBag.PhoneNumber = user.PhoneNumber;
                    ViewBag.NumberKeyCode = _context.NumberKeyCodes;

                    ViewBag.NumberKeyCodeSecondId = user.NumberKeyCodeSecondId;
                    ViewBag.SecondPhonenumber = user.SecondPhonenumber;
                    ViewBag.NumberKeyCodeSecond = _context.NumberKeyCodeSecondS;

                    ViewBag.RegionId = user.RegionId;
                    ViewBag.Regions = _context.Regions;
                    ViewBag.Agencyabout = user.Agencyabout;

                    ViewBag.AgencyImageUrl = user.AgencyImageUrl;

                    ModelState.AddModelError("", "Zəhmət olmasa, tələb olunan formatda şəkil yükləyin");
                    return View(editAgentPRofileViewModel);
                }
            }

            await _usermanager.UpdateAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("AnaSəhifə", "Evimiz"); ;
        }

    }
}