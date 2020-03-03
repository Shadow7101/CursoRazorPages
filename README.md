# CursoRazorPages
Arquivos do curso de (RazorPage)[https://bhrugen.com/] da (Udemy)[https://www.udemy.com/course/advanced-aspnet-core-3-razor-pages].

#### Processo
1) Adcione o pacote abaixo.
```powershell
$ install-package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
```
2) Altere o arquivo **startup.cs** para conter a linha abaixo em **ConfigureServices**.
```c#
$ services.AddRazorPages().AddRazorRuntimeCompilation();
```
3) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```powershell
$ install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```
4) Selecione somente o projeto **Taste.DataAccess** e insira o seguinte pacote em **Nuget**.
```powershell
$ install-package Microsoft.EntityFrameworkCore.SqlServer
```
5) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```powershell
$ install-package Microsoft.AspNetCore.MVC
```
6) Selecione os projetos **Taste.Web** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```powershell
$ install-package Stripe.net
```
7) Mova a pasta `Migrations` de **Taste.Web** para **Taste.DataAccess** e exclua a pasta de **Taste.Web**.
8) Exclua o conteudo da pasta `Migrations` do projeto **Taste.DataAccess**.
9) Mova a classe `ApplicationDbContext` da pasta `Data` **Taste.Web** para **Taste.DataAccess**. 
10) Delete a pasta Data de **Taste.Web**. 
11) Corrija o namespace de `ApplicationDbContext`. 
12) Crie em  **Taste.DataAccess** as pastas `Initialize` e `Repository` e dentro de `Repository` a pasta `IRepository`.
13) De  **Taste.DataAccess** exclua o arquivo `Class1.cs`
14) De  **Taste.Models** crie a pasta `ViewModels`
15) Acesse o site [Bootswatch](https://bootswatch.com) e escolha um tema, e faça o downlaod de `bootstrap.css` desse tema.
16) Acrescentando opção de usar **MVC** no projeto.
- Altere o `startup.cs` na área de **ConfigureServices** para que fique da seguinte forma:
```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
    services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
    services.AddControllersWithViews().AddRazorRuntimeCompilation();
}
```
- Altere o `startup.cs` na área de **Configure** para que fique da seguinte forma:
```c#
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseDatabaseErrorPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseMvc();
}
```
17) Acrescentando os seguintes plugins ao projeto:
- [jqueryui.com](https://jqueryui.com/).
- [datatables.net](http://datatables.net/).
- [fontawesome.com](https://fontawesome.com/).
- [Toastr](https://codeseven.github.io/toastr/)([CDN](https://cdnjs.com/libraries/toastr.js/latest)).
- [Sweet Alert](https://sweetalert.js.org/guides/#installation). 
- [Tiny Docs](https://www.tiny.cloud/docs/demo/full-featured/) ([CDN](https://www.tiny.cloud/my-account/dashboard)).
- [jquery.timepicker](http://www.jonthornton.com/jquery-timepicker/).

Para acrescentar os plugins, acrescente os seguintes `links` CSS no topo do arquivo **_Layout.cshtml**
```html
<!--CSS:-->
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />        
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />        
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />        
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-timepicker/1.10.0/jquery.timepicker.css" />
```

Acrescemte o seguintes `links` JS no rodapé do arquivo **_Layout.cshtml**
```html
<!--JS-->
<script src="https://kit.fontawesome.com/e19c476714.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/cleave.js/1.4.10/cleave.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/cleave.js/1.4.10/addons/cleave-phone.us.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery.serializeJSON/2.9.0/jquery.serializejson.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://cloud.tinymce.com/stable/tinymce.min.js?apiKey=g28lhnxtlihu4l4a381gw7tz47voznshwbi10lmsvlekrfme"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-timepicker/1.10.0/jquery.timepicker.js"></script>  
```

18) Altere o arquivo **site.css** para que fique da seguinte forma:
```css
a.navbar-brand {
    white-space: normal;
    text-align: center;
    word-break: break-all;
}
a {
    color: #0366d6;
}
.nav-pills .nav-link.active, .nav-pills .show > .nav-link {
    color: #fff;
    background-color: #1b6ec2;
    border-color: #1861ac;
}
/* Sticky footer styles
-------------------------------------------------- */
html {
    font-size: 14px;
}
@media (min-width: 768px) {
    html {
        font-size: 16px;
    }
}
.border-top {
    border-top: 1px solid #e5e5e5;
}
.border-bottom {
    border-bottom: 1px solid #e5e5e5;
}
.box-shadow {
    box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
}
button.accept-policy {
    font-size: 1rem;
    line-height: inherit;
}
/* Sticky footer styles
-------------------------------------------------- */
html {
    position: relative;
    min-height: 100%;
}
body {
    /* Margin bottom by footer height */
    margin-bottom: 60px;
}
.footer {
    position: absolute;
    bottom: 0;
    width: 100%;
    white-space: nowrap;
    line-height: 60px; /* Vertically center the text there */
}
.search-background {
    background: url('/images/dust_scratches.png');
}
.backgroundWhite {
    background-color: white;
    padding: 30px;
    border-radius: 10px;
    margin-bottom: 30px;
}
.login-form {
    width: 340px;
    margin: 50px auto;
}
    .login-form form {
        margin-bottom: 15px;
        background: #fff;
        box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        padding: 30px;
    }
    .login-form h2 {
        margin: 0 0 15px;
    }
.form-control, .btn {
    min-height: 38px;
    border-radius: 2px;
}
#logreg-forms {
    width: 412px;
    margin: 10vh auto;
    background-color: white;
    box-shadow: 0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
    transition: all 0.3s cubic-bezier(.25,.8,.25,1);
}
    #logreg-forms form {
        width: 100%;
        max-width: 410px;
        padding: 15px;
        margin: auto;
    }
    #logreg-forms .form-control {
        position: relative;
        box-sizing: border-box;
        height: auto;
        padding: 10px;
        font-size: 16px;
    }
        #logreg-forms .form-control:focus {
            z-index: 2;
        }
    #logreg-forms .form-signin input[type="email"] {
        margin-bottom: -1px;
        border-bottom-right-radius: 0;
        border-bottom-left-radius: 0;
    }
    #logreg-forms .form-signin input[type="password"] {
        border-top-left-radius: 0;
        border-top-right-radius: 0;
    }
    #logreg-forms .social-login {
        width: 390px;
        margin: 0 auto;
        margin-bottom: 14px;
    }
    #logreg-forms .social-btn {
        font-weight: 100;
        color: white;
        width: 190px;
        font-size: 0.9rem;
    }
    #logreg-forms a {
        display: block;
        padding-top: 10px;
        color: lightseagreen;
    }
#logreg-form .lines {
    width: 200px;
    border: 1px solid red;
}
#logreg-forms button[type="submit"] {
    margin-top: 10px;
}
#logreg-forms .facebook-btn {
    background-color: #3C589C;
}
#logreg-forms .microsoft-btn {
    background-color: #2672ec;
}
#logreg-forms .form-reset, #logreg-forms .form-signup {
    display: none;
}
    #logreg-forms .form-signup .social-btn {
        width: 210px;
    }
    #logreg-forms .form-signup input {
        margin-bottom: 2px;
    }
.form-signup .social-login {
    width: 210px !important;
    margin: 0 auto;
}
```
19) Va no site do (Professor)[https://bhrugen.com/] e baixe os recursos necessários.

> Os passos acima cobrem do cápitulo 1 ao 4
> o próximo cápitlo ser Repositório
> 03/03/2020