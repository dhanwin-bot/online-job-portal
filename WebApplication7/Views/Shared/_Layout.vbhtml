<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="~/Content/site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.8.3.js"></script>
</head>
<body>
    <div class="header">
        <h1 style=" text-align:left;">JOBS NZ</h1>
    </div>

    <div class="row">
        <div class="col-12 menu">

            <a href="~/home/index"> Homepage</a>
            <a href="~/About/index"> About Us</a>
            <a href="~/Employer/index"> Registration</a>
            <a href="~/Jobs/index"> Search</a>
        </div>
        @RenderBody();

    </div>

    <div class="header">
        <h1 style="text-align:center;">JOBS NZ Computer Consultancy © All Rights Reserved.</h1>
    </div>
</body>
</html>
