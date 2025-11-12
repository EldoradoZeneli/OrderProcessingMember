# Opdracht Order Processing Members

## Business rules 
Onze opdrachtgever organiseert events voor zijn leden en wenst het leveren van tickets en het maken 
van de nodige bestellingen te automatiseren. De organisatie kent heel wat leden en sommige leden 
hebben de status Gold, Silver of Bronze bereikt.

Elk lid wordt gekenmerkt door een naam, email, id en adres. De events waarvoor een lid zich kan 
inschrijven heeft eveneens een unieke id, naam, adres, datum waarop het plaats zal vinden en de 
kostprijs van een ticket.

Het afhandelen van de bestelling is afhankelijk van de status van de leden. Zo is er voorzien dat leden 
met de status Gold of Silver hun tickets worden opgestuurd met een express-levering. Daarnaast zullen 
deze leden ook een welkomstpakket ontvangen dat eveneens via een express-levering wordt 
opgestuurd.

Voor de andere leden (standard en Brons) gebeurt het opsturen van de tickets met de standard 
levering per post, deze leden ontvangen ook geen welkomstpakket. 
Voor de leden met status Gold, Silver of Bronze bezorgen we naast de tickets ook nog naamplaatjes 
die ze kunnen dragen tijdens het event.

De leden met status Bronze betalen voor een bestelling 100 euro extra aan de organisatie. Leden met 
status Silver daarentegen sponsoren de organisatie door telkens het dubbele van de prijs te betalen.

Als belonging worden ze wel uitgenodigd voor het voorafgaande diner. De Gold-leden betalen 3 maal 
de prijs van een ticket, maar worden eveneens uitgenodigd voor het diner en kunnen bovendien ook 
nog rekenen op een afhaalservice die de leden naar het event brengen. 


## Technische requirements

We werken in een gelaagde architectuur waarbij de business-laag centraal staat. Voor het beheren van 
de gegevens moet het mogelijk zijn om te kiezen tussen verschillende opslagmogelijkheden.  Om te 
testen zullen we gebruik maken van een opslag in het geheugen via collecties. Hou er echter rekening 
mee dat een uitbreiding naar het gebruik van een SQL-databank eenvoudig realiseerbaar moet zijn. 

## Opdracht 
Voorzie een inlog-scherm en UI waarmee de leden zich eenvoudig kunnen inschrijven voor een event. 
Hou er rekening mee dat in de toekomst er willicht aanpassingen/uitbreidingen komen, zoals 
welkomstpakket voor iedereen, extra services voor Gold-leden, afprinten van speciale uitnodigingen, 
… 

## Extra Controle scherm 
Voorzie eveneens een UI waarmee we de toestand van de databank kunnen zien.
