"use strict"

$(document).ready(function(){

    // menu start-------------------------
 
    $(".Menu").click(function(){
        $(".moblie-dropdown").removeClass("d-none");
    })
    $(".close-phone-menu-list").click(function(){
             $(this).parent().addClass("d-none");
    });

    $(".preloader").css(
    {
         opacity:0,
         visibility: "hidden"
    })
    // menu end-------------------------

// slider start-------------------------
let vw = $(window).outerWidth();
let totalWidth = $("#slider .slider-lent li").length * vw;

$("#slider .slider-lent").css("width", totalWidth + "px");

let index = 0;
setInterval(function () {
    index++;

    $("#slider .slider-lent").css(
        {
            left: -index * vw + "px"
        })

    if (index === $("#slider .slider-lent li").length) {
        index = 0;
        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })
    }
}, 6000);

$(document).on("click", "#slider .arrow-right", function () {
    index++;
    let vw = $(window).outerWidth();
    $("#slider .slider-lent").css(
        {
            left: -index * vw + "px"
        })

    if (index === $("#slider .slider-lent li").length) {
        index = 0;
        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })
    }
});

$(document).on("click", "#slider .arrow-left", function () {
    index--;
    let vw = $(window).outerWidth();
    $("#slider .slider-lent").css(
        {
            left: -index * vw + "px"
        })

    if (index < 0) {
        index = $("#slider .slider-lent li").length - 1;
        $("#slider .slider-lent").css(
            {
                left: -index * vw + "px"
            })
    }
});
// slider end-------------------------

var headerclass=document.querySelector(".Header");
var headerTag=document.querySelector("Header");

window.onscroll = function myFunction() {
    if (document.body.scrollTop > 1 || document.documentElement.scrollTop > 1) {
       if(headerclass!=null && headerTag!=null){
        headerclass.classList.add("bg-gray");
        headerTag.classList.add("fixed");
       }
    } else {
       if(headerclass!=null && headerTag!=null){
        headerclass.classList.remove("bg-gray");    
        headerTag.classList.remove("fixed");
       }
    }
  }

// upload personal image for profile
if($(".upload-image-for-profile")!=null){
  $(".upload-image-for-profile").click(function(){
        $(".input-personal").click();
  })
}
  var AllArea=document.querySelector(".a-area");
  var inputImage=document.querySelector(".input-personal");
  var imgDefault=document.querySelector(".img-default")

  if(inputImage!=null){
  inputImage.addEventListener("change", function(e){
    [...e.target.files].forEach(file => {
        if (file.type.match("image/*")) {
            let reader = new FileReader();
          
            reader.onloadend = function (event) {
                
                imgDefault.classList.add("d-none");

                let image = document.createElement("img");
                image.classList.add("img-fluid","w-100","image-personal-h");
                image.src = event.target.result;
                
                AllArea.appendChild(image);
            }

            reader.readAsDataURL(file);
            $(".upload-image-for-profile").addClass("d-none");
            $(".upload-image-for-profile-confirm").removeClass("d-none");
        }
    })
  })
 }
// upload personal image for profile

// tab active  start-------------------------
$(document).on("click", "#search-box li", function () {
    let undeTabActive=$(".tab-active");

    $(".active").removeClass("active");
    $(this).addClass("active");

    let id = $(this).attr("data-id");
    let tabId = $(`.under-tabs[data-id="${id}"]`);
    
    undeTabActive.removeClass("tab-active");
    tabId.addClass("tab-active");
})
// tab active  end-------------------------

$(".heart").click(function(){
    $(this).addClass("d-none").prev().removeClass("d-none").click(function(){
        $(this).addClass("d-none","heart-red").next().removeClass("d-none",);
    })
})

$(".small-images-slider  img").click(function(){
    var src=$(this).attr('src')
    var dataId=$(this).attr('data-id')
    $(".area-big-photo").attr('src' , src)
    $(".area-big-photo").attr('data-id' , dataId)
})

$(".area").keydown(function(e){
    if(e.keyCode==13){
       var commentArea=document.querySelector(".all-comments")
       var div =document.createElement("div");
        var span=document.createElement("span");
        var img=document.createElement("img");
        var txt=document.querySelector(".Area-text")

        span.classList.add("comment-img")
        span.classList.add("mx-2");
        img.classList.add("img-fluid")
        img.src="Images/profile/empty-profile.png";
        span.appendChild(img);
        
        var span1=document.createElement("span");
        span1.classList.add("comment-area");
        span1.innerHTML=txt.value;

        div.classList.add("Comment-area");
        div.classList.add("row");
        div.classList.add("mt-2")

        div.appendChild(span)
        div.appendChild(span1)

        commentArea.appendChild(div)
        txt.value="";
    }
})

// Update Advertisement images-------------------------
$(".close-img").click(function(){
    $(this).parent().remove();
});

$(".Take-big-img").click(function(){
    var id=$(this).prev().prev().attr("data-id");
    var img = $(`.img-h[data-id="${id}"]`);
    var src= $(img).attr("src")
    $(".area-big-photo").attr('src' , src)
});
// Update Advertisement images-------------------------

$(".close-comment").click(function(){
    $(this).parent().parent().remove();
})

$(".close-phone-img").click(function(){
    $(this).parent().removeClass("active")
    $(this).parent().next().addClass("active")
    if($(this).parent().next()==null){
    }
    $(this).parent().remove();
})

$(".add-phoneNumber").click(function(){
    $(".plus-div").removeClass("d-none")
    $(this).addClass("d-none")
    $(".close-input").click(function(){
        $(".plus-div").addClass("d-none");
        $(".add-phoneNumber").removeClass("d-none")
     })
})

 $(".category").change(function () {
        var id = $("option:selected", this).val();
        if (id == 3 || id == 4 || id == 5 || id == 9) {
            $(".floor").removeClass("d-none")
            $(".Room-count").removeClass("d-none")
            $(".floor-count").removeClass("d-none")
            $(".floor").addClass("d-none")
        }
        else if (id == 1 || id == 2 || id == 6) {
            $(".floor").removeClass("d-none")
            $(".Room-count").removeClass("d-none")
            $(".floor-count").removeClass("d-none")
            $(".floor").removeClass("d-none")
        } else {
            $(".floor").addClass("d-none")
            $(".Room-count").addClass("d-none")
            $(".floor-count").addClass("d-none")
        }
    })


$(".annouce-type").change(function(){
  var id= $("option:selected", this).val();
  if(id==2){
      $(".under-annouce-type").removeClass("d-none")
  }else{
      $(".under-annouce-type").removeClass("d-none")
      $(".under-annouce-type").addClass("d-none")
   }
})

$(".City").change(function(){
    var id= $("option:selected", this).attr("value")
    
    if(id==10){
        $(".about-city").removeClass("d-none");
    }else{
        $(".about-city").addClass("d-none");
    }
})

// upload photo to create advertisement start-------------------------
var advertisementImage=document.querySelector(".Imgae-ad-download")
var advertisementInputImg=document.querySelector(".img-ad-advertisement-down")
var advertisementDropareaImage=document.querySelector(".Imgae-ad-download-area")
 
if(advertisementImage!=null){
advertisementImage.onclick=function(){
    advertisementInputImg.click();
  }
}

if(advertisementInputImg!==null){
advertisementInputImg.onchange = function (e) {
    [...e.target.files].forEach(file => {
        if (file.type.match("image/*")) {
            let reader = new FileReader();
          
            reader.onloadend = function (event) {

                let Maindiv=document.createElement("div");
                Maindiv.classList.add("col-lg-3","col-md-4", "col-sm-6" ,"col-8" ,"mt-3","p-0")

                let image = document.createElement("img");
                image.classList.add("img-fluid","w-100","img-dh");
                image.src = event.target.result;

                let i=document.createElement("i");
                i.classList.add("fas" ,"fa-window-close" ,"text-danger" ,"close-img-agent")
                Maindiv.appendChild(i);

                Maindiv.appendChild(image);
                advertisementDropareaImage.appendChild(Maindiv);
                
            }
            reader.readAsDataURL(file);
        }
    })
}
}
// upload photo to create advertisement start-------------------------


//  upload photo for advertisement update-------------------------
 var adiv=document.querySelector(".div-click");
 var input=document.querySelector(".hidden-input")
 var dropareaImage = document.querySelector(".small-images-slider")
 var phonearea=document.querySelector(".small-images-slider-a");

if(adiv!=null){
    adiv.addEventListener("click", function(){ input.click(); });
}

if(input!=null){
input.onchange = function (e) {
    [...e.target.files].forEach(file => {
        if (file.type.match("image/*")) {
            let reader = new FileReader();
          
            reader.onloadend = function (event) {
                let Maindiv=document.createElement("div");
                Maindiv.classList.add("col-xl-3","col-lg-4","col-md-3", "col-sm-6" ,"col-8" ,"mt-2")

                let image = document.createElement("img");
                image.classList.add("img-fluid","w-100","img-h","position-relative","rounded");
                image.src = event.target.result;
                 
                var a=document.createElement("a");
                a.classList.add("btn", "btn-success", "btn-block" ,"Take-big-img","text-white")
                a.innerHTML="Yeni şəkil";

                Maindiv.appendChild(image);
                Maindiv.appendChild(a);

                if(vw>992){
                    dropareaImage.appendChild(Maindiv);
                }else{
                     phonearea.appendChild(Maindiv);
                }
            }
            reader.readAsDataURL(file);
        }
    })
    }
}
//  upload photo for advertisement update-------------------------

//upload Photo for User start-------------------------
var UserDiv=document.querySelector(".upload-user-img");
var UserImg=document.querySelector(".user-img")
var UserImgArea=document.querySelector(".border-image")

if(UserDiv!==null){
    UserDiv.onclick=function(){
        UserImg.click();
    }
}
if(UserImg!=null){
    UserImg.addEventListener("change", function(e){
        [...e.target.files].forEach(file => {
            if (file.type.match("image/*")) {
                let reader = new FileReader();
              
                reader.onloadend = function (event) {
                    let div=document.createElement("div");
                    let image = document.createElement("img");
                    let i=document.createElement("i");
                    div.classList.add("col-lg-5","col-md-10","col-6","position-relative", "p-0");
                    
                    i.classList.add("fas" ,"fa-window-close" ,"text-danger" ,"close-img-personal")
                    image.classList.add("img-fluid","img-condition","rounded","w-100");
                    image.src = event.target.result;
                    div.appendChild(image);
                    div.appendChild(i);
    
                    UserImgArea.appendChild(div);
                }
    
                reader.readAsDataURL(file);
                $(UserDiv).addClass("d-none");
            }
            
        })
    })
}

$(document).on("click",".close-img-personal",function(e){
    $(e.target).parent().remove();
    $(UserDiv).removeClass("d-none");
    });

//upload Photo for User start-------------------------

//$(".Agents-div").hide();
//$(".agent-checkbox").click(function(){
//      $(".Agents-div").slideToggle("d-none")
//   })

// Upload photo for agents start-------------------------
var AgentDiv=document.querySelector(".Imgae-download");
var AgentImg=document.querySelector(".img-advertisement-down")
var AgentImgArea=document.querySelector(".Image-download-area")

if(AgentDiv!=null){
    AgentDiv.onclick=function(){
        AgentImg.click();
    }
}

if(AgentImg!=null){
    AgentImg.addEventListener("change", function(e){
        [...e.target.files].forEach(file => {
            if (file.type.match("image/*")) {
                let reader = new FileReader();
                reader.onloadend = function (event) {
                    let div=document.createElement("div");
                    let image = document.createElement("img");
                    let i=document.createElement("i");
                    div.classList.add("col-lg-3","col-md-4","col-6","position-relative", "p-0");
                    
                    i.classList.add("fas" ,"fa-window-close" ,"text-danger" ,"close-img-agent")
                    image.classList.add("img-fluid","img-condition","rounded","w-100");
                    image.src = event.target.result;
    
                    div.appendChild(image);
                    div.appendChild(i);
    
                    AgentImgArea.appendChild(div);
                }
    
                reader.readAsDataURL(file);
                $(AgentDiv).addClass("d-none");
            }
        })
    })
}

$(document).on("click",".close-img-agent",function(e){
    $(e.target).parent().remove();
    $(AgentDiv).removeClass("d-none");
});
// Upload photo for agents end-------------------------

    //$(document).on("ready", , function () {
    //    console.log($(this))
    //})

    //[...document.querySelectorAll("field-validation-valid span")].forEach(node => console.log(node));
    ////if ($(".field-validation-valid").html() != "") {
        
    ////}
 
})
$(".Agents-div").hide();
$(".plus-order").click(function(){
    $(".Agents-div").slideToggle();
});

// $(".order-send-btn").click(function(){
//     let OrderType=$(".order-type").val();
//     let UserName=$(".User-name").val();
//     let OrderName=$(".Advertisement-name").val();
//      let OrderAbout=$(".Order-about").val();
//     let NumberCodeOne=$(".number-code-1").val();
//     let NumberCodeTwo=$(".number-code-2").val();
//     let NumberCodeOneInput=$(".number-code-input-1").val();
//     let NumberCodeTwoInput=$(".number-code-input-2").val();
//     let divHead=document.createElement("div");
//     divHead.classList.add("head","col-12");
//      let h5=document.createElement("h5");
//      h5.classList.add("p-1","m-0");
//      let spanOrderType=document.createElement("span");
//      spanOrderType.classList.add("text-primary");
//      spanOrderType.innerText="("+OrderType+")";
//      h5.innerHTML=OrderName;
//      h5.appendChild(spanOrderType);
//      divHead.appendChild(h5);
//      console.log(divHead)
//      let divBody=document.createElement("div");
//      divBody.classList.add("body","col-lg-8","col-sm-7","col-12");
//      let pBody=document.createElement("p");
//      pBody.classList.add("p-2","m-0");
//      pBody.innerText=OrderAbout;
//      divBody.appendChild(pBody)
//      console.log(divBody)
//      let divOrderman=document.createElement("div");
//      divOrderman.classList.add("orderman","col-lg-4","col-sm-5","col-12");
//      let divRow=document.createElement("div");
//      divRow.classList.add("row","p-1","m-0")
//      let DivImgOrder=document.createElement("div");
//      DivImgOrder.classList.add("img-order","col-md-3","col-sm-12","col-4","p-0")
//      let img=document.createElement("img");
//      img.classList.add("img-fluid");
//      DivImgOrder.appendChild(img);
//      let DivAnother=document.createElement("div");
//      DivAnother.classList.add("col-md-9","col-sm-12","col-8");
//      let spanBold=document.createElement("span");
//      spanBold.classList.add("bold");
//      let iProfile=document.createElement("i");
//      iProfile.classList.add("fas", "fa-user-alt", "fa-xs", "mr-1")
//      spanBold.innerText=UserName;
//      let spanNumberOne=document.createElement("span");
//      spanNumberOne.classList.add("Number-anonym")
//      let iconPhone=document.createElement("i");
//      iconPhone.classList.add("fas", "fa-mobile-alt" , "mr-2")
//      spanNumberOne.innerText=NumberCodeOne+NumberCodeOneInput;
//      spanNumberOne.appendChild(iconPhone);
//      let spanNumberTwo=document.createElement("span");
//      spanNumberTwo.classList.add("Number-anonym")
//      spanNumberOne.innerText=NumberCodeTwo+NumberCodeTwoInput;
//      spanNumberOne.appendChild(iconPhone);
//      DivAnother.appendChild(spanBold);
//      DivAnother.appendChild(spanNumberOne);
//      DivAnother.appendChild(spanNumberTwo);
//      divRow.appendChild(DivImgOrder);
//      divRow.appendChild(DivAnother);
//      divOrderman.appendChild(divRow)
//      console.log(divOrderman)
// })

//var firstnameError = document.querySelectorAll(".validation-error span");
//var registerButton = document.querySelector(".register");

//registerButton.addEventListener("click", function () {
//[...firstnameError].forEach(e => {
//    if (e.innerHTML != "") {
//        e.previousElementSibling.classList.remove("d-none");
//        console.log(e)
//    } else {
//        e.previousElementSibling.classList.remove("d-none");
//        e.previousElementSibling.classList.add("d-none");
//    }
//  })
//})


//[...firstnameError].forEach(e => {
//    if (e.innerHTML != "") {
//        e.previousElementSibling.classList.remove("d-none");
//        console.log(e)
//    } else {
//        e.previousElementSibling.classList.remove("d-none");
//        e.previousElementSibling.classList.add("d-none");
//    }
//})
//all ajax 

$(document).ready(function () {
    $("#checkbox").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
            $.ajax({
                url: "/Ajax/Premium?IsChecked=" + IsChecked,
                type: "GET",
                success: function (res) {
                    if (res == "false") {
                        alert("Xəta baş verdi!!!")
                        return
                    }
                    $(".Premium").html() == "";
                    $(".Premium").html(res);
                }
            });
     
    });
});
$(document).ready(function () {
    $("#checkbox1").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/VIP?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".VIP").html() == "";
                $(".VIP").html(res);
            }
        });

    });
});
$(document).ready(function () {
    $("#checkbox2").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        console.log("asas");
        $.ajax({
            url: "/Ajax/Usual?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Usual").html() == "";
                $(".Usual").html(res);
            }
        });

    });
});
$(document).ready(function () {
    $("#checkbox3").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        console.log("asas");
        $.ajax({
            url: "/Ajax/NewPlace?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".NewPlace").html() == "";
                $(".NewPlace").html(res);
            }
        });

    });
});
$(document).ready(function () {
    $("#checkbox4").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/OldPlace?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".OldPlace").html() == "";
                $(".OldPlace").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox5").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Villa?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Villa").html() == "";
                $(".Villa").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox6").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/House?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".House").html() == "";
                $(".House").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox7").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/YasrHouse?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".YasrHouse").html() == "";
                $(".YasrHouse").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox8").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Office?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Office").html() == "";
                $(".Office").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox9").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Garage?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Garage").html() == "";
                $(".Garage").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox10").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/Place?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".Place").html() == "";
                $(".Place").html(res);
            }
        });
    });
});
$(document).ready(function () {
    $("#checkbox11").click(function () {
        var IsChecked = $(this).first("input").prop("checked");
        $.ajax({
            url: "/Ajax/PropertyOnject?IsChecked=" + IsChecked,
            type: "GET",
            success: function (res) {
                if (res == "false") {
                    alert("Xəta baş verdi!!!")
                    return
                }
                $(".PropertyOnject").html() == "";
                $(".PropertyOnject").html(res);
            }
        });
    });
});