![alt text](https://scontent.fcgh9-1.fna.fbcdn.net/v/t1.6435-9/186540273_1137786460035398_8714970517469162849_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeGTTivJdMmg-o__HWWZMb4qVf1ZTqX5Q2BV_VlOpflDYJcl2S-M0tgITMg0z5CL5hbiZV7z2SfMTgcBoF0X4FeV&_nc_ohc=y2tO1kPgWW0AX_ZcZrc&_nc_ht=scontent.fcgh9-1.fna&oh=a1d94d72786b6ae36fd62d3047248613&oe=60C7EE99)

# euroPlus4
### Sistema de controle para máquinas industriais, casas inteligentes e veículos automotores.

## O que é o euroPlus ?
O euroPlus surgiu com a ideia de elevar o nível de sistemas industriais para a núvem, além da integração com sistemas ERP e controle de produção.
O inicio começou em 2010 quando vi a necessidade de coletar dados de uma máquina para estudos futuros, como não encontrei nenhum produto industrial que cabia no
orçamento do cliente, resolvi desenvolver uma aplicação desktop onde o cliente precisaria apenas de um computador para rodar a aplicação.
O sistema foi se aperfeiçoando e sendo distribuido para diversas aplicações em diversas fábricas espalhadas pelo mundo. Na versão atual (4) eu decidi criar
uma espécie de Framework para desenvolvimento rápido de aplicações industriais baseadas em PC e abrir o sistema para que todos possam utiliza-lo. Sim agora o euroPlus
é open source!

## O que esse sistema pode fazer ?
* Realizar a interface homem máquina entre equipamentos
* Subir dados para DB possibilitando o controle de variáveis de processo
* Realizar a comunicação com controladores industriais e módulos de injeção eletrônica de veiculos
* Utilizar PC's comum evitando gastos exorbitantes com interfaces proprietarias
* Login de usuário usando tags RFID (28/04/21)

## Open Source
* A ideia é difundir o euroPlus para qualquer desenvolvedor utilizar como base

## Desafios
* Implementar o padrão SOLID no fonte
* Implementar o suporte para diversos banco de dados
* Refatorar o código para reduzir o acoplamento facilitando a alteração e manutenção
* Implementar diversos protocolos de comunicação


## Tecnologias
* .NET Framework
* C#
* MVVM
* ModBus TCP
* EtherCat
* SQL


## Screenshot's
![alt text](https://scontent.fcgh4-1.fna.fbcdn.net/v/t1.6435-9/179130051_1126454201168624_7085700059582259211_n.jpg?_nc_cat=101&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeEz5YU91Zdw7ori7PopMZlkUU9fcyU1DplRT19zJTUOmaW61g0F5HAuXQm7LQE5WOIA9lKgh9BnO7A991kWrlSo&_nc_ohc=QmQLXsmlxicAX8jwk8_&_nc_oc=AQlk6jtLp-huJE37pE2vF_8GjK1a00yDcT3mbhq8X2ZDEg0nU6Jve4c-M142nObl0yENwW_q9r7pFehMbkaiAu1-&_nc_ht=scontent.fcgh4-1.fna&oh=e46668d646d2a939f56458dc6dc4e6fb&oe=60AE56C6)
![alt text](https://scontent.fcgh5-1.fna.fbcdn.net/v/t1.6435-9/178827819_1126454171168627_3591240927055622616_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeHxSl49ROfrDgXiJpuKP16MgVLfyEQmNzmBUt_IRCY3OWTRItJLeQOSAmgWYdJx95pnUZmhB3xNiagp7RRoyWor&_nc_ohc=CyXEL3gtHxIAX_sOoLD&tn=I5KAyYXAh1tuCCWu&_nc_ht=scontent.fcgh5-1.fna&oh=d640abc88e41b284ff39878a47c6e172&oe=60ADCB59)
![alt text](https://scontent.fcgh5-1.fna.fbcdn.net/v/t1.6435-9/179525502_1126454221168622_240111091757570595_n.jpg?_nc_cat=109&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeHb_MHykd3eDm7ZeM6F4xsltXu_AvNYPm-1e78C81g-b-CVZqQXjmPWqff5n_gqNMK7wxYEIxvzfGuAXuC-Lmmi&_nc_ohc=6vHCjSatb4wAX_1nEAu&_nc_ht=scontent.fcgh5-1.fna&oh=b57da899e0ac15069bc4fd1dda3a9211&oe=60ADEA9A)
![alt text](https://scontent.fcgh4-1.fna.fbcdn.net/v/t1.6435-9/178992858_1126454244501953_6688159907512695407_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeH_98eqz8IhHAekaT00aMFmT3_Nf8GkdTRPf81_waR1NL_j52B9YLqIHjC1G3i6Wh0sSbAEU-AD9i1F6P9UW3-W&_nc_ohc=edKSmj9G_DMAX-tKJKq&_nc_ht=scontent.fcgh4-1.fna&oh=b45fe6c86a8e195a2c5115c58105d800&oe=60AE5C31)
![alt text](https://scontent.fcgh5-1.fna.fbcdn.net/v/t1.6435-9/179040068_1126454237835287_1072407827948660062_n.jpg?_nc_cat=104&ccb=1-3&_nc_sid=730e14&_nc_eui2=AeGDSrKtDh_A8qrOsA0jvSZu4TxV0UAfFXfhPFXRQB8Vd97Jl71AtLS7_1uJ-ydicX7WGYs00elUTOSvH1F7OJq8&_nc_ohc=lfqxpucLjGYAX_2KcpM&_nc_ht=scontent.fcgh5-1.fna&oh=dfcc82ec60effdc3ac57118511fdb0ff&oe=60AE1E66)
