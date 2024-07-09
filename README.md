# FitTrackr

## Descri��o do Projeto

**FitTrackr.Api v1** � uma Web API desenvolvida utilizando o framework .NET 8. Esta API � projetada para suportar um sistema de gerenciamento de treinamentos f�sicos, abrangendo funcionalidades relacionadas a usu�rios, planos de treinamento, sess�es de treino, exerc�cios e mais. O sistema � estruturado para permitir a cria��o, atualiza��o, exclus�o e consulta de dados de diversas entidades que comp�em um plano de treinamento f�sico completo.

A API oferece endpoints organizados em diferentes categorias principais, como Usu�rios, Planos de Treinamento, Fases de Treinamento, Sess�es de Treinamento, Exerc�cios e Tipos de Exerc�cios, entre outros. Estes endpoints fornecem opera��es CRUD (Create, Read, Update, Delete) para gerenciar as informa��es necess�rias para construir e acompanhar programas de treinamento f�sico personalizados.

### Principais Funcionalidades:
- **Gerenciamento de Usu�rios**: Cadastro e consulta de usu�rios.
- **Planos de Treinamento**: Cria��o, atualiza��o, exclus�o e consulta de planos de treinamento e suas fases.
- **Sess�es de Treinamento**: Consulta de sess�es de treinamento por planos, fases, semanas e dias espec�ficos.
- **Exerc�cios**: Cria��o, atualiza��o, exclus�o e consulta de exerc�cios e sess�es de exerc�cios.
- **Equipamentos**: Gerenciamento de equipamentos usados nos treinamentos.
- **N�veis de Intensidade, Tipos de Exerc�cios e Notas**: Configura��o de n�veis de intensidade, tipos de exerc�cios e adi��o de notas �s sess�es de exerc�cios.

## Modelo Relacional

Este modelo relacional representa a estrutura de dados do FitTrackr, uma aplica��o que gerencia planos de treinamento f�sico. O modelo foi desenvolvido utilizando a abordagem Code-First com o Entity Framework Core (EF Core). A abordagem Code-First permite definir o modelo de dados utilizando classes C#, que s�o posteriormente traduzidas em um esquema de banco de dados relacional pelo EF Core. Esta abordagem facilita a manuten��o do c�digo e a evolu��o do modelo de dados ao longo do tempo.

### Componentes do Modelo

- **TrainingPlan**: Representa um plano de treinamento que agrupa v�rias fases de treinamento.
- **TrainingPhase**: Cada plano de treinamento � dividido em fases, que s�o compostas por sess�es de treinamento. A entidade TrainingPhase possui informa��es como n�mero de semanas, dias de treinamento e sess�es de treinamento associadas.
- **TrainingSession**: Representa uma sess�o de treinamento espec�fica dentro de uma fase de treinamento. Cada sess�o est� associada a um dia da semana e possui um conjunto de exerc�cios.
- **ExerciseSession**: Detalha os exerc�cios realizados em uma sess�o de treinamento, incluindo o nome do exerc�cio, o conjunto de repeti��es e anota��es associadas.
- **Exercise**: Representa os exerc�cios dispon�veis no sistema, com detalhes como nome, descri��o e tipo de equipamento necess�rio.
- **ExerciseNote**: Cont�m anota��es espec�ficas para um exerc�cio, que podem ser associadas a v�rias sess�es de exerc�cios.

### Relacionamentos

- **TrainingPlan** possui m�ltiplas **TrainingPhases**.
- **TrainingPhase** possui m�ltiplas **TrainingSessions**.
- **TrainingSession** possui m�ltiplas **ExerciseSessions**.
- **ExerciseSession** est� associada a um **Exercise** e pode ter m�ltiplas **ExerciseNotes**.

### Diagrama Relacional

![Modelo Relacional](docs/fittrackr_relational_diagram.png)

Este diagrama ilustra as entidades e os relacionamentos entre elas, proporcionando uma vis�o clara da estrutura de dados do FitTrackr.

A utiliza��o do EF Core com abordagem Code-First permite uma evolu��o cont�nua do modelo de dados, facilitando a manuten��o e a escalabilidade da aplica��o FitTrackr.

### Configura��o do Banco de Dados Localmente via Code First com Entity Framework Core

Este guia r�pido ir� ajud�-lo a configurar o banco de dados localmente em uma nova m�quina utilizando o Entity Framework Core e PostgreSQL. Este tutorial assume que todas as migra��es j� est�o criadas e os pacotes necess�rios est�o instalados no projeto.

### Pr�-requisitos

- **Docker** instalado.
- **.NET 8.0** ou superior instalado.

### Configura��o de Conex�o

Certifique-se de que a string de conex�o do banco de dados est� corretamente configurada no seu `appsettings.json` com o `Host` setado como *localhost*:

```json
{
  "ConnectionStrings": {
    "Database": "Host=localhost;Port=5432;Database=fittrackr;Username=postgres;Password=postgres;Include Error Detail=true"
  }
}
```

### Configura��o via Console do Gerenciador de Pacotes (Package Manager Console)

1. **Abrir o Console do Gerenciador de Pacotes**:

   No Visual Studio, v� para **Ferramentas** > **Gerenciador de Pacotes NuGet** > **Console do Gerenciador de Pacotes**.

2. **Selecione o Projeto Default**:

   No Console do Gerenciador de Pacotes, em `Default Project` selecione o projeto **Infrastructure**.

3. **Selecione o Startup Project**:

   No Visual Studio, em `Startup Project` selecione o projeto **Web.Api**.

3. **Atualizar o Banco de Dados**:

   No Console do Gerenciador de Pacotes, execute o comando abaixo para aplicar as migra��es existentes ao banco de dados:

   ```powershell
   Update-Database
   ```

Com esses passos, voc� deve estar apto a configurar o banco de dados localmente em uma nova m�quina usando a abordagem Code First com Entity Framework Core e PostgreSQL.