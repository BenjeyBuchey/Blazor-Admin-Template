# Blazor Admin Template

Blazor Admin Template is a Blazor Server project with simple account management using ASP.NET Identity and modified pages for login/add user/edit user/delete user/reset pw. It uses an own user class that inherits from IdentityUser and adds a sample property.

On first start the program will seed the standard user roles (Date\Enums\UserRoles.cs) and an admin user with the following credentials:

Email: admin@admin.com

Password: 123Pa$$word!

## Installation
Change connection string in appsettings.json according to your database.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Credits
MudBlazor for its awesome components. [https://mudblazor.com/](https://mudblazor.com/)

MarcoTheFirst for the BlazorCookieLoginMiddleware [https://github.com/MarcoTheFirst](BlazorCookieLoginMiddleware)

## License
[Apache](https://choosealicense.com/licenses/apache-2.0/)
