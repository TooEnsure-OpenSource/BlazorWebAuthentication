# Forms & Authentication WebApp with Blazor Webassembly

Blazor is awsome.

This repository focuses on the Authentication aspect of *Blazor Webassembly*.

From simple *Authentication* using blazor built-in authentication all the way down to *Api* calls storing users into an SQL-Lite database.

This repo is really made for everybody interested in .Net and blazor framework.

>**Notice:** I use code behind files (the logic) with components and simply add the logic into the pages of the site. Although this isn't nessaruy nor do I know if its considered bad code or good code, I find it easier and efficent thats all.

***Your'll Learn***
* Form Validation
* Form Authentication


## Getting Started

First clone repo:

```https://github.com/TooEnsure-OpenSource/BlazorWebAuthentication.git```

## Step 1 : Define Model
>/Shared/*.cs


The ```UserRegister.cs``` & ```UserLogin.cs``` files are our model class, it's how we'll shape the model process of a user logging in.

For instance, in order for an user to login we define a login model.

The login model will collect username and email.

The ```Requried``` parameter must be set in order to validate such field isn't left empty.

In this case both *username* & *password* are requried in order for user to login.


## Step 2 : Create Form
>/Client/Pages/

The ```LogIn.razor``` file is where we'll use blazor built in form validation **EditForm**, which an **Model** and an method to execute when form is valid on submit **OnValidSubmit** is passed.


