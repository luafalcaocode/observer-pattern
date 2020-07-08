# Padrão de Projetos Observer

O padrão de projetos Observer cria uma relação de dependência entre um e muitos objetos de modo que quando o estado deste objeto é alterado todos os outros são notificados e podem tomar decisões baseados nisso. 

**Fonte:** Head First Design Patterns, Cap. 2; Design Patterns, GOF, pág. 281.

Abaixo segue 3 exemplos de possíveis implementações do padrão observer para fins de estudo:

1. Um relógio mestre (subject) obtém as horas de todos os países do mundo de acordo com o fuso horário de cada região e altera seu estado com os valores de hora, minutos e segundos atualizados. Ao fazer isso, dois relógios (um analógico e outro digital) tomam conhecimento da mudança de seu estado e obtém a hora, os minutos e segundos em tempo real para, por exemplo, exibir na tela de seu dispositivo ou realizar algum outro processamento. 

2. Em um cenário de inteligência artifical muitos agentes inteligentes (observadores) interagem com os andares de um prédio através de sensores (subjects) e monitoram as luzes. Quando ocorre uma mudança na iluminação do ambiente de algum andar o agente responsável toma conhecimento por meio dos sensores e realiza alguma ação. Poderia, por exemplo, acionar os alarmes ou o setor de manutenção do prédio para ver o que está acontecendo. 

3. Um dispositivo responsável por obter dados meteorológicos sobre temperatura, humidade e pressão atmosférica (subject) envia dados atualizados para três tipos diferentes de visualizações de um sistema. Sempre que os dados são atualizados as visualizações mudam as informações na tela para refletir o novo estado.

# Rodando o projeto:

### Pré-requisitos: .NET Core SDK versão 3.1 e um editor de código como o Visual Studio Code

- abra o terminal do seu sistema operacional e digite o comando **git clone https://github.com/luafalcaocode/observer-pattern.git**
- navegue até a pasta do projeto: **cd observer-pattern**
- execute o projeto: **dotnet run --project observer-pattern**
- pare a aplicação e analise o código fonte :)

