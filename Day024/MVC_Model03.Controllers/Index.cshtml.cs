@{
    ViewData["Title"] = "Home Page";
    var cars = ViewData["cars"] as List<Car>;
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>

@* @foreach(var item in cars)
{
    <h3>@item.ID</h3>
    <h3>@item.Brand</h3>
    <h3>@item.Speed</h3>
} *@
