# Projeto pratelivros

## Especificação do caso de uso - Reportar erro

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Primeira versão  | Gabriel FERREIRA |

### 1. Resumo 
Este caso de uso permite que um usuário reporte um erro no sistema

### 2. Atores 
- Visitante
- Leitor

### 3. Pré-condições
São pré-condições para iniciar este caso de uso:
- Não possui

### 4. Pós-condições
Após a execução deste caso de uso, espera que o sistema:
- Não possui

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário insere suas credenciais (Nome e E-mail), seleciona o tipo de problema, o descreve e clica em "Enviar" | --- |
| --- |2. O sistema registra as informações cadastradas pelo usuário e as envia ao e-mail de todos os moderadores | --- |

#### 5.2. Fluxo de excessão

##### 5.2.1 Nome em branco
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário não insere seu Nome e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'Nome' é obrigatório") |

##### 5.2.2 Nome muito curto
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere um nome muito curto no campo 'Nome' e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O tamanho mínimo de nome é 4 caracteres") |

##### 5.2.3 Nome muito grande
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere um nome muito grande no campo 'Nome' e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O tamanho máximo de nome é 30 caracteres") |

##### 5.2.4 E-mail em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário não insere o E-mail e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'E-mail' é obrigatório") |

##### 5.2.5 E-mail inválido
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere um E-mail inválido | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Este não é um endereço de E-mail válido") |

##### 5.2.6 Descrição em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário não insere a Descrição do problema e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'Descrição' é obrigatório") |

##### 5.2.7 Descrição muito grande
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere uma descrição de problema muito grande no campo 'Descrição' e clica em "Enviar" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O tamanho máximo de descrição é 300 caracteres") |

### 6. Protótipos de Interface
#### 6.1. Página de visitante
![pagina de visitante](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/c60980e2-b796-475d-a053-185890833a7b)

#### 6.2. Página de leitor
![pagina de leitor](https://github.com/PI-InfoWeb-CNAT/2023-pratelivros/assets/93940387/a4c9096c-01d0-41e2-ae25-8c42e0ace6f2)

### 7. Diagrama de classe de domínio usados neste caso de uso
`A ser desenvolvido pelo aluno.`

### 8. Dicionário de dados
- Nome - Uma cadeia de caracteres alfabéticos tamanho 30
- E-mail - Uma cadeia de caracteres alfanuméricos tamanho 30
- Tipo de problema - Uma lista de opções contendo "Erro no sistema", "Conteúdo impróprio", "Violação das diretrizes" e "Outro"
- Descrição - Uma cadeia de caracteres de tamanho 300

### 9. Regras de negócio
- Nome - Mínimo de 4 caracteres; iniciado por letras maiúsculas
- E-mail - Um conjunto de caracteres (com exceção dos caracteres especiais, sendo permitido apenas o ponto) seguidos, respectivamente, por um arroba, outro conjunto de letras e um ou mais domínios de topo
