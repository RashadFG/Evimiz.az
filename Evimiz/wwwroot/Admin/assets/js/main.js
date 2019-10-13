var Application = angular.module("App", []);
Application.controller('AppController', function ($scope) {
    $scope.Tab = 1;
});

$(document).ready(function () {
    "use strict";
    
    $(document).on("click", ".sub-menu", function () {
        $(this).children(".sub").toggle();
        $(this).children(".sub").toggleClass("forScroll");
        if ($(this).children(".sub").hasClass("forScroll")) {
            $("#sidebar").css({ "overflow-y": "scroll" })
        }
        else {
            $("#sidebar").css({ "overflow-y": "auto" })
        }
    })

    $(document).ready(function () {
        $(".load-more-btn-profile-area").click(function (e) {
            e.preventDefault();
            var TotalCount = +$(this).prev().val();
            var skip = +$("#changeSkipProfile").val();
            var UserIdForAdvertisement = $("#UserIdForAdvertisement").val()
            $.ajax({
                url: "/Ajax/LoadMoreProfile?skip=" + skip + "&UserIdForAdvertisement=" + UserIdForAdvertisement,
                type: "GET",
                success: function (response) {
                    $(".profile-area").append(response);
                    skip += 4;
                    $("#changeSkipProfile").val(skip);
                    if (skip >= TotalCount) {
                        $(".load-more-btn-profile-area").remove();
                    }
                }
            });
        });
    });

    $(document).ready(function () {
        $(".load-more-btn-AllConfirmedAdvertisemenet").click(function (e) {
            e.preventDefault();
            var TotalCount = +$(this).prev().val();
            var skip = +$("#changeSkipAllConfirmedAdvertisemenet").val();
            $.ajax({
                url: "/Ajax/LoadMoreUnconfirmed?skip=" + skip,
                type: "GET",
                success: function (response) {
                    $(".AllConfirmedAdvertisemenet").append(response);
                    skip += 4;
                    $("#changeSkipAllConfirmedAdvertisemenet").val(skip);
                    if (skip >= TotalCount) {
                        $(".load-more-btn-AllConfirmedAdvertisemenet").remove();
                    }
                }
            });
        });
    });

    $(document).ready(function () {
        $(".load-more-btn-AllConfirmedAdvertisemenet").click(function (e) {
            e.preventDefault();
            var TotalCount = +$(this).prev().val();
            var skip = +$("#AllConfirmedAdvertisemenet").val();
            $.ajax({
                url: "/Ajax/LoadMoreUnconfirmed?skip=" + skip,
                type: "GET",
                success: function (response) {
                    $(".AllConfirmedAdvertisemenet").append(response);
                    skip += 4;
                    $("#AllConfirmedAdvertisemenet").val(skip);
                    if (skip >= TotalCount) {
                        $(".load-more-btn-AllConfirmedAdvertisemenet").remove();
                    }
                }
            });
        });
    });

    $(document).ready(function () {
        $(".load-more-btn-AllUnConfirmedAdvertisemenet").click(function (e) {
            e.preventDefault();
            var TotalCount = +$(this).prev().val();
            var skip = +$("#AllUnConfirmedAdvertisemenet").val();
            $.ajax({
                url: "/Ajax/LoadMoreConfirmed?skip=" + skip,
                type: "GET",
                success: function (response) {
                    $(".AllUnConfirmedAdvertisemenet").append(response);
                    skip += 4;
                    $("#AllUnConfirmedAdvertisemenet").val(skip);
                    if (skip >= TotalCount) {
                        $(".load-more-btn-AllUnConfirmedAdvertisemenet").remove();
                    }
                }
            });
        });
    });

    $(document).ready(function () {
        $(".load-more-btn-AllDeletedAdvertisemenet").click(function (e) {
            console.log("asasa")
            var TotalCount = +$(this).prev().val();
            var skip = +$("#AllDeletedAdvertisemenet").val();
            console.log(skip)
            $.ajax({
                url: "/Ajax/LoadMoreDeleted?skip=" + skip,
                type: "GET",
                success: function (response) {
                    $(".AllDeletedAdvertisemenet").append(response);
                    skip += 4;
                    $("#AllDeletedAdvertisemenet").val(skip);
                    if (skip >= TotalCount) {
                        $(".load-more-btn-AllDeletedAdvertisemenet").remove();
                    }
                }
            });
        });
    });
});

