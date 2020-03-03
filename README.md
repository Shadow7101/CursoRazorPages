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
15) Acesse o site [Bootswatch](https://bootswatch.com) e escplha um tema, e faça o downlaod de `bootstrap.css` desse tema.