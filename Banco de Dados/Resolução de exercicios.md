# Capitulo 01

**Questões:**

1. Discuta cada um dos seguintes termos:

*Resposta a. dados:*
    
> Dados são um conjunto bruto de fatos que poderam ou não se tornar informações dependendo de seu contexto ou aplicação e de como é o trabalho sobre esses dados. Por exemplo um dado pode gerar uma informação muito importante e valiosa pra uma determinada empresa e para outra empresa pode permanecer em forma de dado ou seja sem relevancia para a empresa aplicação. Exemplos podem ser datas de aniversário, nome de fornecedor ou lucro mensal.
    
*Resposta b. campo:*
    
> Um campo recebera um rótulo e normalmente ira armazenar somente um tipo de dado, ou seja ele seria como uma coluna em uma aplicação comum. Um campo poderia ser Nome ou idade por exemplo.
    
*Resposta c. registro:*

> Registro, tupla ou linha será onde os dados de um unico item de dado será armazenado em um agrupamento lógico de dados. Por exemplo as informações de um individuo como nome, idade, sexo e altura.
    
*Resposta d. arquivo:*

> Conjunto de dados e registros que compoem uma informação ou não. Um exemplo seria as matriculas de alunos em uma escola.
    
____________________________________________________________________________________________________________________________

2. O que é redundância de dados e quais características do sistema de arquivos podem levar a ela?
    
*Resposta 2.*
    
> Quando diferentes versôes de um mesmo dado aparecem em locais diferentes. Por exemplo, quando o departamento de vendas de uma empresa armazena o nome de uma representante de vendas como "Cris Silva" e o departamento de recursos humanos armazena o nome da mesma pessoa como "Cris G. da Silva" nesse caso o perfil de um mesmo colaborador estaria duplicado em nosso banco de dados.
____________________________________________________________________________________________________________________________

4. O que é um SGBD e quais são suas funções?
    
*Resposta 4.*
    
> SGBD ( Sistema de gerenciamento de bancos de dados é um conjunto de programas que gerenciam a estrutura do banco de dados e controlam o acesso aos dados armazenados.
____________________________________________________________________________________________________________________________

7. Qual é o papel de um SGBD e quais são suas vantagens? E as suas desvantagens?

*Resposta 7.*

> O SGBD serve como intermediário entre o usuário e o banco de dados. o SGBD recebe todas as solicitações de aplicações e as traduz nas operações complexas necessárias para atendê-las. Suas vantagens são aprimoramento do compartilhamento de dados, aprimoramento da segurança de dados, melhoria na integração dos dados, minimizaçãoda inconsistência dos dados, aprimoramento do acesso aos dados, aprimoramento da tomada de decisão, aumento de produtividade do usuário final entre outras muitas. Em suas desvantagens estão no custo alto para implementação de um sistema SGBD alem do alto tempo demandado, que só aumenta conforme o tamanho da empresa, e Risco com a seguranção já que por mais que o sistema administre os varios usuários em casos necessários ainda abre muitas portas de risco para que usuarios não autorizados acessem informações que não eram de sua grade.
____________________________________________________________________________________________________________________________

10. O que São metadados?

*Resposta 10.*

> Um metadado traz uma visão mais completa dos dados de um banco de dados. Ele fornece uma descrição das caracteristics dos dados e do conjunto de relacionamento que liga os dados encontrados no banco de dados. Um exemplo seria um valor de 1000 em um dado em nosso banco seu metadado pode ser metros, R$, unidades, Kg, etc...
____________________________________________________________________________________________________________________________

11. Explique por que o projeto do banco de dados é importante.

*Resposta 11.*

> Um banco bem projetado facilita o gerenciamento dos dados e gera informações precisas e valiosas. Já um banco de dados mal projetado provavelmente se tornará um solo fértil para erros difíceis de restrear ou até mesmo gerar tomadas de decições ruins, esse tipo de decisão pode levar organizações ao fracasso. Vale ressaltar que um projeto de bancos de dados pode interferir até mesmo no desenpenho de um bom SGBD.

# Capitulo 02
    
**Questões:**

1. Discuta a importância da modelagem de dados.

> A modelagem traz uma visão ampla sobre o projeto ao qual se deseja criar assim como em uma planta de casa, onde todo o projeto e desenhando e dimencionado para que o conjunto das parte (quartos, cozinha, banheiros, etc...) estejam em equilibrio para criar uma boa estrutura contra eventuais falhas, projetos de banco de dados são relativamente iguais é necessário uma visão geral sobre o projeto para que uma falha como por exemplo o incoformidade de dados entre o estoque e o setor de vendas seja evitado.
    
2. O que é uma regra de negócio e qual é sua finalidade na modelagem de dados?

> Uma regra de negócio é uma descrição breve, precisa e sem ambiguidades de uma política.=, procedimento ou princípio em uma determinada organização. As regras de negócio decorrentes de uma descrição detalhada das operações de uma organização ajudam a criar e aplicar ações no interior de seu ambiente organizacional ou seja elas são necessárias para ajustar o software desenvolvido á forma de trabalho da organização em foco. Através dela conseguimos identificar componentes essencias para o desenvolvimento de banco de dados como identificação adequada de entidades, atributos, relacionamentos e restrições.
    
3. Como é possivel traduzir regras de negócio em componentes de modelos de dados?

> Atraves de uma regra de negocio do tipo "um cliente pode gerar muitas faturas e uma fatura é gerada por apenas um cliente" conseguimos determinar que á relação entre cliente e faturas como de 1:M (um para muitos) sendo assim uma regra de negocio foi traduzida para uma parte do modelo de dados.
    
14. O que é um relacionamento e quais são seus três tipos?


> Os relacionamentos descrevem associações entre dados. A maioria deles trata de relações entre duas entidades. Quando os componentes básicos dos modelos de dados foram apresentados, destacaram-se três tipos de relacionamentos entre dados: uma para muitos (1,M),
muitos para muitos (M, N) e um para um (1:1).
    
**Problemas:**
    
24. Apresente as regras de negócio que representam o DER apresentado na Figura P2.6. (Observe que o DER reflete alguns pressupostos de simplificação. Por exemplo, cada livro é escrito por apenas um autor. Além disso, lebre-se de que o DER é sempre lido do lado "1" para o lado "M", independente da orientação de seus componentes.)
    
![Figura P2.6: DER pé de galinha
para o Problema 24](https://github.com/ThreeDP/IFSP---Material-de-Estudo/blob/master/Banco%20de%20Dados/Untitled%20Diagram.png)
    
*Resposta 24.*

    1. Uma editora pode publicar um ou varios livros, Um livro poderá ter somente uma editora.
    2. Um autor pode escrever um ou muitos livros, Um livro só pode ser escrito por um autor.
    3. Um autor pode assinar um ou muitos contratos de publicação, Um contrato só pode ser assinado por um autor.
    4. Uma editora pode gerenciar um ou muitos contratos, Um contrato so pode ser gerenciado por uma editora.
    
25. Crie um DER pé de galinha para cada uma das seguintes descrições. (Observação: A palavra vários significa simplesmente "mais de um" no ambiente de modelagem de bancos de dados.)
    
a. Cada divisão da meaCo Corporation é composta de vários departamentos. Cada departamento possui vários funcionários atribuídos a ele, mas cada funcionário trabalha em apenas um departamento. Cada departamento é gerenciado por um funcionário trabalha em apenas um departamento. Cada departamento é gerenciado por um funcionário e cada um desses gerentes pode gerenciar apenas um departamento ao mesmo tempo.

*Resposta a.*

> 
    
b. Durante determinado período de tempo, um cliente pode alugar várias fitas de vídeo da locadora BigVid. Cada fita de vídeo da BigVid pode ser alugada a vários clientes nesse período.

*Resposta b.*

![Figura P2.6: DER pé de galinha
para o Problema 24](https://github.com/ThreeDP/IFSP---Material-de-Estudo/blob/master/Banco%20de%20Dados/Untitled%20Diagram.png)

c. Um avião de linhas aéreas pode ser encarregado de vários voos, mas cada voo é feito por apenas um avião.

*Resposta c.*

d. A KwikTite Corporation opera várias fábricas. Cada fábrica localiza-se em uma única região. Cada região pode "abrigar" várias fábricas da KwikTite. Cada fábrica emprega muitos funcionários , mas cada um desses funcionários é empregado de apenas um fábrica.

*Resposta d.*

e. Um funcionário pode obter vários graus de ensino e cada grau de ensino pode ser obtido por vários funcionários.

*Resposta e.*

# Capitulo 03
    
**Questões:**

1. Qual é a diferença entre banco de dados e uma tabela?

> Uma tabela possui um conjunto de informações sobre um determinado assunto como por exemplo alunos e é dividida em linhas e colunas e cada ponto onde essas linhas e colunas se cruzam a um dado armazenado. Bancos de dados possuem tabelas em sua concepção porem com uma abordagem mais ampla já que ele realiza a relação entre varias tabelas formando assim uma "tabela muito maior de dados".
    
2. O que significa dizer que um banco de dados apresenta integridade de entidades e integridade referencial?

> Para apresentar integridade de entidades cada valor de chave primária deve ser exclusivo para garantir que todas as linhas sejam idetificadas exclusivamente por essa chave, para manter tal integridade, não se permite um valor nulo dentro do campo de chave primária. Ja para apresentar integridade referencial a chave estrangeira precisa referir-se á uma tupla com referencia a uma chave primaria válida existente em outra relação.

9. O que são os homônimos e sinônimos e por que devem ser evitados no projeto de bancos de dados?

> Os homônimos são palavras de pronúncia similar ou de ortografia idêntica, mas com significados diferentes, um exemplo seria leve (do verbo levar) e leve (significando "de pouco peso"), em banco de dados homônimos indica utilização do mesmo nome para atributos diferentes como CNAME que pode ser usado tanto para idetificar o nome de um cliente como o de um fornecedor porem em tabelas diferentes.
Ja sinônimos é o oposto de homônimo e indica a utilização de nomes diferentes para descrever o mesmo atributo como por exemplo carro e automóvel. Tanto Homônimos quanto Sinônimos pode gerar confusões como referencia a atributos não relacionados ao processo ou ação do usuario ou a duplicação de dados dentro do banco de dados.

**problemas:**
    
8. Para cada tabela, identigique a chave primária e a(s) chave(s) estrangeira(s). Se uma tabela não tiver uma chave estrangeira, escreva Nenhum no espaço fornecido.
    
![Tabela exercicio 8: ](https://github.com/ThreeDP/IFSP---Material-de-Estudo/blob/master/Banco%20de%20Dados/TABELA%20CAP03%20EX08.png)

*Resposta 8.*

![Tabela exercicio 8 Resolvido: ](https://github.com/ThreeDP/IFSP---Material-de-Estudo/blob/Trabalho-v1.0.1/Banco%20de%20Dados/TABELA%20CAP03%20EX08%20RESOLVIDO.png)

16. Crie o diagrama relacional para mostrar o relacionameto entre funcionários, loja e região.

*Resposta 16.*     

![Diagrama relacional problema 16 ](https://github.com/ThreeDP/IFSP---Material-de-Estudo/blob/Trabalho-v1.0.1/Banco%20de%20Dados/Diagrama%20relacional%20CAP03%20EX16.png)        
    
    
