# Sistema de Gerenciamento de Estados de Tarefas


> Projeto de um gerenciamento de tarefas em C# utilizando o Designer Patterns State, para alterar seu estado para Criado, Em Progresso, Concluído ou Cancelado, através de solicitações feitas na camada de controller. Programado em inglês. 

 <hr/>
 
 ## 🚨 Requisitos do Sistema

### Padrão State
- Utilização do padrão State para estados de tarefas.
- Estados: Created, In Progress, Completed, Cancel.
- Classe Task com id, name, description.

### Endpoints RESTful
- POST /tasks (Cria a tarefa)
- Estados:
<br> PUT /tasks/{id}/start (Inicia a tarefa)
<br> PUT /tasks/{id}/complete (Conclui a tarefa)
<br> PUT /tasks/{id}/cancel (Cancela a tarefa)
<br> GET /tasks/{id} (Pesquisa)

### Persistência de Dados
- Utilização do Entity Framework.

<hr/>


<br/>

## ☕ Usando o Sistema de Gerenciamento de Estados de Tarefas

Para usar esse projeto, siga estas etapas:
<br> 📌 Baixe ou clone esse repositório
<br> 📌 Utilize a IDE que você está acostumada(o) para acessar os códigos
<br> 📌 No terminal digite o comando para criar o banco de dados:

  ```
  update-database
  ```
### ⚠ Atenção 

<br> ❗ O projeto já vem com uma migration de criação de banco, se não tiver digite os comandos para criar o banco de dados:
  ```
  add-migration teste
--
  update-database
  ```

<hr/>
