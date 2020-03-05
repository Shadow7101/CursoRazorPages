
# CursoRazorPages

Arquivos do curso de [[RazorPage](https://bhrugen.com/)] da [[Udemy](https://www.udemy.com/course/advanced-aspnet-core-3-razor-pages)].

## Anotações do curso

### Parte 1

Criando projetos:

> O sistema esta seguindo a arquitetura **DDD** onde o sistema fica separado em camadas, considerando a camada de FrontEnd (***01-FrontEnd***), onde teremos o projeto Web, geralmente com o no da Solução, seguido de Web (exemplo ***Taste.Web***).

- Veja [[aqui](https://github.com/Shadow7101/CursoRazorPages/blob/master/01-FrontEnd/Taste.Web/wwwroot/Images/documentos/arquitetura.PNG)] como ficou a arquitetura.
- Se você esta usando ***Visual Studio Code*** pegue [[aqui](https://github.com/Shadow7101/CursoRazorPages/wiki/Criando-projeto-no-Visual-Studio-Code)] os comandos de ***Terminal*** para criar seu projeto.
- Se você não esta usando o nosso ***VS Code***, da uma boa olhada na arquitetura e exclua as classes **Class1.cs** que são criadas automaticamente para os projetos do tipo **classlibrary**.

### Parte 2

Corrigindo a versão do framework dos projetos:

> Quando criamos projetos pela linha de comando (ou não) nem sempre o dotnet cria todos os projetos apontando para o mesmo framework, sendo assim se faz necessário abrir o **arquivo de projeto** de todos os projetos e checar para **qual framework** este arquivo esta apontando, minha preferencia é o último framework estavel, veja o modelo abaixo:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

</Project>
```

### Parte 3

Adicionando referências as bibliotecas nos projetos:

> Se considerarmos que você esta usando o Visual Studio, é necessário abrir o **Package Manage Console**, se você esta usando o Visual Studio Code, basta abrir o **TERMINAL**.

- Se você usando **Visual Studio Code** [[aqui](https://github.com/Shadow7101/CursoRazorPages/wiki/Configurando-pacotes-do-projeto-VSCode)] você encontra um script que executa as ações necessárias.
- Se você esta usando o **Visual Studio**, clique [[aqui](https://github.com/Shadow7101/CursoRazorPages/wiki/Configurando-pacotes-no-VisualStudio)] e siga o passo a passo com as ações necessárias.


### Parte 4

Criando o contexto de acesso a dados do projeto:

- Na raiz do projeto **Taste.DataAccess** crie uma nova classe chamada **ApplicationDbContext.cs** e deixe essa classe com a aparencia abaixo:

```c#
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Taste.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

    }
}

```

### Parte 5

Ajustando arquivo **startup.cs** a camada de frontend:

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

### Parte 6

Referenciando os projetos:

> Em qualquer arquitetura evoluida uma aplicação é separada em camadas determinadas, na arquitetura DDD uma máxima é persistente, todas as camadas ***referenciam*** a camada de domínio e a camada de dominio não ***referencia*** ninguem.

 As referências devem ser criadas da seguinte forma:
 
| No projeto abaixo:| Taste.Web  | Taste.Application  | Taste.DataAccess | Taste.Domain |
|-------------------|------------|--------------------|------------------|--------------|
| Taste.Web         |            |         X          |        X         |      X       |
| Taste.Application |            |                    |        X         |      X       |
| Taste.DataAccess  |            |                    |                  |      X       |
| Taste.Domain      |            |                    |                  |              |

- Se você esta usando ***Visual Studio Code*** criei um script [aqui] para acrescentar as referências nos projetos conforme a tabela.
- Se você esta usando ***Visual Studio*** siga o passo a passo conforme documento neste [link] para adicionar as referencias.

### Passo 7 

Ajuste do CSS do front-end.

9)  Acesse o site [Bootswatch](https://bootswatch.com) e escolha um tema, e faça o downlaod de `bootstrap.css` desse tema.
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

18. Altere o arquivo **site.css** para que fique como o neste [link](https://github.com/Shadow7101/CursoRazorPages/wiki/site.css-(Cap%C3%ADtulo-3)).

19. Va no site do [Professor](https://bhrugen.com/) e baixe os recursos necessários.

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
