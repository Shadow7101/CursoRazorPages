# CursoRazorPages
Arquivos do curso de RazorPage (Udemy) [https://www.udemy.com/course/advanced-aspnet-core-3-razor-pages]

#### Processo
1) Adcione o pacote abaixo.
```sh
$ install-package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
```
2) Altere o arquivo **startup.cs** para conter a linha abaixo em **ConfigureServices**.
```sh
$ services.AddRazorPages().AddRazorRuntimeCompilation();
```
3) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
$ install-package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```
4) Selecione somente o projeto **Taste.DataAccess** e insira o seguinte pacote em **Nuget**.
```sh
$ install-package Microsoft.EntityFrameworkCore.SqlServer
```
5) Selecione os projetos **Taste.Models** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
$ install-package Microsoft.AspNetCore.MVC
```
6) Selecione os projetos **Taste.Web** e **Taste.DataAccess** e insira o seguinte pacote em **Nuget for Solution**.
```sh
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
```sh
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
    services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
    services.AddControllersWithViews().AddRazorRuntimeCompilation();
}
```
- Altere o `startup.cs` na área de **Configure** para que fique da seguinte forma:
```sh
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
17) Acrescentnado os seguintes plugins ao projeto:
- [jqueryui.com](https://jqueryui.com/).
- [datatables.net](http://datatables.net/).
- [fontawesome.com](https://fontawesome.com/).
- [Toastr](https://codeseven.github.io/toastr/)([CDN](https://cdnjs.com/libraries/toastr.js/latest)).
- [Sweet Alert](https://sweetalert.js.org/guides/#installation). 
- [Tiny Docs](https://www.tiny.cloud/docs/demo/full-featured/) ([CDN](https://www.tiny.cloud/my-account/dashboard)).
- [jquery.timepicker](http://www.jonthornton.com/jquery-timepicker/).

