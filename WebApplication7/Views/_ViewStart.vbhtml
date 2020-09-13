﻿@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        * {
            box-sizing: border-box;
            font-family: Arial, Helvetica, sans-serif;
        }

        body {
            margin: 0;
        }

        .row::after {
            content: "";
            clear: both;
            display: block;
        }



        .col-1 {
            width: 8.33%;
            float: left;
            padding: 15px;
        }

        .col-2 {
            width: 16.66%;
            float: left;
            padding: 15px;
        }

        .col-3 {
            width: 25%;
            float: left;
            padding: 15px;
        }

        .col-4 {
            width: 33.33%;
            float: left;
            padding: 15px;
        }

        .col-5 {
            width: 41.66%;
            float: left;
            padding: 15px;
        }

        .col-6 {
            width: 50%;
            float: left;
            padding: 15px;
        }

        .col-7 {
            width: 58.33%;
            float: left;
            padding: 15px;
        }

        .col-8 {
            width: 66.66%;
            float: left;
            padding: 15px;
        }

        .col-9 {
            width: 75%;
            float: left;
            padding: 15px;
        }

        .col-10 {
            width: 83.33%;
            float: left;
            padding: 15px;
        }

        .col-11 {
            width: 91.66%;
            float: left;
            padding: 15px;
        }

        .col-12 {
            width: 100%;
            float: left;
            padding: 15px;
        }



        .header {
            background-color: #9933cc;
            color: #ffffff;
            padding: 15px;
        }


        .menu {
            overflow: hidden;
            background-color: gray;
        }


            .menu a {
                float: left;
                display: block;
                color: #f2f2f2;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
            }

                .menu a:hover {
                    background-color: #0099cc;
                }

        img {
            max-width: 100%;
            height: auto;
        }
    </style>
</head>
</html>