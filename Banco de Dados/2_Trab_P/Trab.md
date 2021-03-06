# 9. 
> A Global Computer Solutions (GCS) é uma empresa de consultoria em tecnologia da informação com diversos escritórios localizados por todos os Estados Unidos. O sucesso da empresa tem como base a capacidade de maximizar seus recursos - ou seja, combinar funcionários altamente capacitados com projetos de acordo com a região. Para melhor gerenciar seus projetos, a GCS entrou em contato com você para projetar um banco de dados, de modo que os gerentes da GBS possam rastrear seus clientes, funcionários, projetos, programações de projetos, designações e faturas.

### 9.0.
> Banco de dados da GCS deve dar suporte a todas as necessidades de operações e informações da empresa. Segue uma descrição básica das principais entidades:

### 9.1.
> Os funcionários que trabalham para a GBS possuem ID, sobrenome, inicial do meio, nome, região e data de contratação.

### 9.2.
> As regiões válidas são as seguintes: Noroeste (NW), Sudeste (SW), Centro-Oeste/Norte (MN), Centro-Oeste/Sul (MS), Nordeste (NE) e Sudeste (SE).

### 9.3.
> Cada funcionário possui várias habilidades e vários funcionários possuem a mesma habilidade.

### 9.4.
> Cada habilidade possui ID, descrição e taxa de pagamento. As habilidades válidas são: entrada de dados I, entrada de dados II, analista de sistemas I, analista de sistemas II, projetista de bancos de dados I, projetista de bancos de dados II, Cobol I, Cobol II, C++ I, C++ II, VB I, VB II, ColdFusion I, ColdFusion II, ASP I, ASP II, ABD Oracle, ABD MS SQL Server, engenheiro de redes I, engenheiro de redes II, administrador da web, redator técnico e gerente de projetos. A Tabela P6.1a apresenta um exemplo do resumo de habilidades.

### 9.5.
> A GCS possui diversos clientes. Cada cliente possui ID, nome, número de telefone e região.

### 9.6.
> A GCS trabalha por projetos. Um projeto baseia-se em um contrato entre o cliente e a GCS para projetar, desenvolver e implementar uma solução computadorizada. Cada projeto possui características específicas, como ID, cliente a que pertence, descrição breve, data (ou seja, data em que o contrato do projeto foi assinado), data de início (estimada), data de conclusão (também estimada), orçamento (custo estimado total do projeto), data real de início, data real de conclusão, custo real e um funcionário designado como gerente.

### 9.7.
> O custo real é atualizado todas as sextas-feiras, somando-se o custo da respeciva semana (calculado multipplicando-se as horas trabalhadas de cada funcionário pela taxa de pagamento de cada habilidade) ao custo real.

{TABELA P6.1a}

### 9.8.
> O funcionário gerente do projeto deve preencher uma programação de projeto que, na verdade, é um plano de projeto e desenvolvimento. Nessa programação (ou plano), o gerente deve determinar as tarefas que serão executadas para levar o proeto do início ao fim. Cada tarefa possui ID, descrição breve, data de inicio e conclusão, tipo de habilidade necessária e número de funcionários (com as habilidades necessárias) exigidos. As tarefas gerais são: entrevista inicial, projeto do banco de dados e do sistema, implementação, codificação, teste, avaliação final e encerramento. Por exemplo, a GCS pode ter a programação de projeto apresentada na Tabela P6.1b.

{TABELA P6.1b}

### 9.9.
> Designações: A GCS reúne todos os seus cuncionários por região e, a partir desse conjunto, são designados para uma tarefa especifica agendada peo gerente de projetos. Por exemplo, para a programação do primeiro projeto, sabe-se que no periodo de 1º/3/08 a 6/3/08 são necessários um Analista de Sistemas II, um Projetista de Banco de Dados I e um Gerente de Projetos. (O gerente de Projetos é designado quando o projeto é criado e permanece durante o projeto.) Ultilizando essa informação, o GCS busca os funcionários localizados na mesma região do cliente, combinando as habilidades necessárias e designando-os para a tarefa do projeto.

{TABELA P6.1c}

### 9.10.
> Cada tarefa da programação do projeto pode tetr diversos funcionários designados e um determinado funcionário pode trabalhar em várias tarefas do projeto. No entanto, um funcionário pode trabalhar em apenas uma tarefa por vez. Por exemplo, se um funcionário já estiver designado para trabalhar em uma tarefa de 20/2/08 a 3/3/08, não poderá trabalhar em outra tarefa até que a atual termine. A data em que uma designação é concluída não coincide necessariamente com a data de conclusão da tarefa na programação do projeto, pois pode ser concluida com antecedência ou com atraso.

### 9.11.
> Dadas as informações precedentes, pode-se ver que a designação associa um funcionário a uma tarefa de projeto, utilizando a programação. Portanto, para rastrear a designação, são necessárias, pelo menos, as seguintes informações: ID de designação, funcionário, tarefa na programação do projeto, data de início da designação, data de encerramento da designação (que pode ser qualquer data, já que alguns projetos atrasam ou adiantam a programação). A Tabela P6.1c apresenta um exemplo de forma de designação.

### 9.12.
> (Observação: O número de designação é apresentado como prefixo do nome do funcionário; por exemplo, 101, 102.) Assuma que as designações apresentadas anteriormente sejam as únicas existentes a partir de sua data. O número de designação pode ser qualquer número que atenda a seu projeto de banco de dados.

### 9.13.
> As horas que um funcionário trabalha são mantidas em um resgitro de trabalho que contém um registro das horas reais trabalhadas por funcionário em determinada designação. O registro de trabalho é um formulário semanal que o funcionário preenche no fim de cada semana (sexta-feira) ou no fim de cada mês. O formulário contém a data (de cada sexta-feira do mês ou do último dia de trabalho do mês, caso não caia em uma sexta-feira), a ID de designação, o total de horas trabalhadas na semana (ou até o término do mês) e o número da conta em que a entrada do registro de trabalho é cobrada. Obviamente, cada entrada pode se relacionar a apenas uma conta. Uma lista de exemplo das entradas do registro de trabalho para o projeto do primeiro exemplo é apresentada na Tabela P6.1d.

### 9.14.
> Por fim, a cada 15 dias uma conta é emitida e enviada ao cliente, totalizando as horas trabalhadas no projeto nesse período. Quando a GBS gera uma conta, utiliza o número de conta para atualizar as entradas de registro de trabalho que fazem parte dessa conta, utiliza o número de conta para atualizar as entradas de registro de trabalho, e cada entrada pode estar relacionada a apenas um conta. A GCS enviou uma conta em 15/3/08 para o primeiro projeto (Xerox), com o total de horas trabalhadas entre 1º/3/08 e 15/3/08. Portanto, pode-se assumir com segurança que há apenas uma conta nessa tabela e que essa conta cobre as entradas do registro de trabalho apresentadas no formulário citado.

**Sua tarefa é criar um banco de dados que cumpra as operações descritas nesse problema. As entidades mínimas necessárias são: funcionário, habilidade, cliente, região, projeto, programação de projeto, designação, registro de trabalho e conta. (Há entidades adicionais necessárias que não estão listadas.)**

### 9.15.
> Crie todas as tabelas e todos os relacionamentos necessários.

### 9.16.
> Crie os índices necessários para manter a integridade de entidade ao utilizar chaves primárias surrogates.

### 9.17.
> Preencha as tabelas conforme necessário (como indica no exemplo de dados e formulários).

{TABELA P6.1d}
