using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace root.Client.Shared.Authentication.AuthLoginComponent
{
    public partial class AuthLogin
    {
        private root.Shared.UserLogin user = new root.Shared.UserLogin();

        
       

        private async Task HandleLoginAsync()
        {
            
            System.Console.WriteLine($"user: {user.Username} pw: {user.Password}");
            await LocalStorage.SetItemAsync<bool>("isAuth", true);
            await AuthStateProvider.GetAuthenticationStateAsync();
        }

        
    }
}
