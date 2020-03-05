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

18) Altere o arquivo **site.css** para que fique como o neste link:https://github.com/Shadow7101/CursoRazorPages/wiki/site.css-(Cap%C3%ADtulo-3).

19) Va no site do [(Professor)<https://bhrugen.com/]> e baixe os recursos necessários.

> Os passos acima cobrem do capítulo 1 ao 3
> o próximo cápitlo ser Repositório
> 03/03/2020


### Capítulo 4
> 04/03/2020

Trabalhando com entidades, repositórios e a metodologia Unit Of Work.

- Criada das as interfaces e classes do DDD.
- Criada a interface e classe UnitOfWork
- Criada a classe/tabela Category de exemplo.
- Criado migration
- Atualizado o banco de dados

Criei um artigo [Entity Framework Troubleshooting](https://github.com/Shadow7101/CursoRazorPages/wiki/Entity-Framework-Troubleshooting), pode ajudar se alguem (eu) tiver problema no Entity Framework no futuro.
