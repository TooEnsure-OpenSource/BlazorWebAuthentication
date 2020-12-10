# Forms & Authentication WebApp with Blazor Webassembly

Take a look at project documentation in the ```doc``` folder.

>***Note***: I may be cought up on other projects so there's a possibility that **doc** folder,
is empty, i'll try my best in the following.

## Getting Started

First clone repo:

```https://github.com/TooEnsure-OpenSource/BlazorWebAuthentication.git```


>Shared/

UserLogin.cs

```c#
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
```