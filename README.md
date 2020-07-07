# Padrão de Projetos Observer

O padrão de projetos Observer cria uma relação de dependência entre um e muitos objetos de modo que quando o estado deste objeto é alterado todos os outros são notificados e podem tomar decisões baseados nisso. 

Fonte: Head First Design Patterns, Cap. 2

Abaixo segue 3 xemplos de possíveis implementações do padrão observer para fins de estudo:

1. Um relógio como subject obtém as horas de todos os países de acordo com o fuso horário de cada região e altera seu estado com os valores de hora, minutos e segudos. Ao fazer isso os observadores tomam conhecimento da mudança de seu estado e obtém a hora, os minutos e segundos em tempo real para, por exemplo, exibir na tela ou realizar algum outro processamento. 

2. Em um cenário de inteligência artifical um muitos agentes inteligentes interagem com os andares de um prédio através de sensores e monitoram as luzes. Quando ocorre uma mudança na iluminação do ambiente de algum andar o agente responsável toma conhecimento por meio de sensores e realiza alguma ação. Poderia acionar alarmes ou o setor de manutenção do prédio para ver o que está acontecendo. 

3. Um dispositivo responsável por obter dados meteorológicos sobre temperatura, humidade e pressão atmosférica (sujeito) envia dados atualizados para três tipos diferentes de visualizações de um sistema. Sempre que os dados são atualizados as visualizações mudam as informações na tela para refletir o novo estado.
