using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace root.Client.Shared.Authentication.AuthRegisterComponent
{
    public partial class AuthRegister
    {
        root.Shared.UserRegister user = new root.Shared.UserRegister();

        [Inject] protected NavigationManager NavManager { get; set; }

        public void HandleRegister()
        {
            System.Console.WriteLine($"Adding user to database");
            NavManager.NavigateTo("page/login");
        }
    }
}
