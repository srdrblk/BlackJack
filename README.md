# BlackJack
 3. İskambil kağıtları için genel (generic) bir data yapısı tasarlamanızı istiyoruz. Bu hazırlamış olduğunuz data yapısını, 21 oyununa göre nasıl implemente edersiniz? 
 
README 
This program is a simple version of Blackjack game. It have 4 layer and one app 

Contract: 

This layer is determined according to the needs that differ according to the project. "Extentions" can be used in this layer, but since it will make this layer dependent on other layers and I think it is appropriate to stay on the same layer with entities.

Models:
This layer contains only entities and "extensions" of these entities. However, while creating these entities, I added a few calculations to the properties. Since I need these calculations all the time, I found it appropriate to do this, but I generally did not prefer it. One of the reasons for this is the "PlayerStatuEnum" property in the Player entity. Because it had to get an input

Repository:
This layer contains repos and interfaces of these repos. Repositories contains calculation about related entity. In this project there are deckrepository(deck), playerrepository(player) and gameRepository(deck and player). Generaly every entities hava a repository or use Base Repository if layer have ganric repository. But it is not written on stone. 

Service:
This layer is used to customize the methods in the repository according to the application and to prevent the application from directly accessing the calculations. For exampla: Admin panels use all crud methods but website generally uses get and getalls so we don't need to give permission to website for all methods but it is not a situtation on this version

Apps-BlackJack:
It is clasic mvc design pattern project. On "Startup" add singelton instance for dependency . Thanks to that I dont lose my variables that I need but It can be a problem when we works on complex project. On Client there are three main button create game, restart game and close game , three player button "get card","close deal" and get a set (add new player). Some of these buttons use simple ajax request and you find these request on wwwroot-> js -> game.js

CVS
Blackjack needs .Net Core sdk 3 to work.(https://dotnet.microsoft.com/download/dotnet-core/3.0)

CONTACT 
serdarbilek@outlook.com
