## PT: Como Configurar o Projeto

Siga as instruções abaixo para configurar o projeto e restaurar a base de dados.

---

### Pré-requisitos
1. Instale o [.NET SDK](https://dotnet.microsoft.com/download) (versão 6 ou superior).
2. Instale o [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads) ou outra instância do SQL Server.
3. Instale o [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) para gerenciar o banco de dados (opcional, mas recomendado).

---

### Passos para Restaurar o Banco de Dados

1. **Localize os Arquivos do Banco de Dados:**
   - Navegue até a pasta `Database` dentro do projeto.
   - Os arquivos do banco de dados são:
     - `FoodMenu.mdf` (dados)
     - `FoodMenu_log.ldf` (log)

2. **Restaurar o Banco de Dados:**
   - Abra o **SQL Server Management Studio (SSMS)**.
   - Conecte-se à sua instância do SQL Server.
   - Clique com o botão direito em **Databases** (banco de dados) e selecione **Attach** (Anexar).
   - No painel que aparece:
     - Clique em **Add**.
     - Navegue até o local onde você clonou este repositório e selecione o arquivo `FoodMenu.mdf`.
     - Clique em **OK**.

3. **Verifique o Banco de Dados:**
   - Após anexar o banco, ele aparecerá na lista de bancos de dados no SSMS com o nome `FoodMenu`.
   - Use a opção **New Query** para executar consultas, se necessário.

---

### Configuração do Projeto

1. Abra o terminal e navegue até o diretório do projeto:
   ```bash
   cd Food_Menu
2. Atualize o arquivo appsettings.json (se necessário):
   - Certifique-se de que a string de conexão está configurada corretamente para o SQL Server local. O formato será algo assim:
  ```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=FoodMenu;Trusted_Connection=True;"
}
```
3. Execute o projeto:
```bash
  dotnet watch run
```

## EN: How to Set Up the Project

Follow the instructions below to set up the project and restore the database.

---

### Prerequisites
1. Install the [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or higher).
2. Install [SQL Server Express](https://www.microsoft.com/sql-server/sql-server-downloads) or another instance of SQL Server.
3. Install [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) to manage the database (optional, but recommended).

---

### Steps to Restore the Database

1. **Locate the Database Files:**
- Navigate to the `Database` folder within the project.
- The database files are:
- `FoodMenu.mdf` (data)
- `FoodMenu_log.ldf` (log)

2. **Restore the Database:**
- Open **SQL Server Management Studio (SSMS)**.
- Connect to your SQL Server instance.
- Right-click **Databases** and select **Attach**.
- In the panel that appears:
- Click **Add**.
- Browse to the location where you cloned this repository and select the `FoodMenu.mdf` file.
- Click **OK**.

3. **Verify the Database:**
- After attaching the database, it will appear in the list of databases in SSMS with the name `FoodMenu`.
- Use the **New Query** option to run queries, if necessary.

---

### Project Setup

1. Open the terminal and navigate to the project directory:
```bash
   cd Food_Menu
```
2. Update the appsettings.json file (if necessary):
- Make sure the connection string is configured correctly for your local SQL Server. The format will be something like this:
```bash
"ConnectionStrings": {
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=FoodMenu;Trusted_Connection=True;"
}
```
3. Run the project:
```bash
dotnet watch run
```
