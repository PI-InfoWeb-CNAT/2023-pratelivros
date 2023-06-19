# Projeto pratelivros

## Especificação do caso de uso - Realizar cadastro

### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2023 | **1.00** | Primeira versão | Lucas de LIMA |

### 1. Resumo
Este caso de uso permite que um visitante se cadastre no sistema.

### 2. Atores
- Visitante

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- O visitante acessar a página inicial sistema
- O visitante apertar no botão "Cadastrar-se" no cabeçalho do site

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Armazene os dados do usuário cadastrado e, portanto, o permita utilizar as funcionalidades da plataforma

### 5. Fluxos de evento

#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O visitante acessa a página inicial do sistema | --- |
|2. O visitante aperta no botão "Cadastrar-se" | --- |
| --- |3. O sistema redireciona o visitante para a página de cadastro de usuário | --- |
|4. O visitante insere os seus dados | --- |
|--- |5. O sistema valida e armazena os dados cadastrados |
|6. O visitante é redirecionado para a página inicial de leitor | --- |

#### 5.2. Fluxo de excessão
|  Ator  | Sistema |
|:-------|:------- |
|1. O visitante acessa a página inicial do sistema | --- |
|2. O visitante aperta no botão "Cadastrar-se" | --- |
| --- |3. O sistema redireciona o visitante para a página de cadastro de usuário | --- |
|4. O visitante insere os seus dados | --- |
|--- |5. O sistema não valida os dados inseridos pelo visitante e exibe uma mensagem de erro |

### 6. Protótipos de Interface
#### 6.1. Página inicial do sistema
![pagina de visitante](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/3ca8d765-60e6-4381-8a62-0d156fe3361d)

#### 6.2. Página de cadastro de usuário
![pagina de cadastro de usuario](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/a1b105ce-2153-4a69-a54e-2fc428912acd)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`
