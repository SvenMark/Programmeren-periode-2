# README #

### Opdrachten & Test voor programmeren 2 ###

* Versie
* 1.0.0

### How do I get set up? ###

Je kan de volgende YouTube video bekijken met uitleg hoe je kunt beginnen met de programmeren 2 opdrachten.
Dit is wellicht duidelijker dan de tekst en uitleg hieronder. 

https://www.youtube.com/watch?v=cWS3P4mqnCo

het git commando: 
git clone https://jorislops@bitbucket.org/jorislops/programmeren2testsstudent.git

* Stap 1 Haal het project binnen m.b.v. git.
       -Maak een directory aan waar je wilt clonen,
       -Gebruik het volgende commando om het project binnen te halen:
             git clone https://jorislops@bitbucket.org/jorislops/programmeren2testsstudent.git
* Stap 2 Open het project dat je zojuist hebt binnengehaald in Visual Studio (navigeer naar de directory en open de solution)
* Stap 3 Link de missende DLL. Klik rechts op references in de Solution Explorer. 
      Add Reference --> Browse 
      <projectdir>\programmeren2testsstudent\Programmeren2Opdrachten\dll\Programmeren2Tests.dll
* Stap 4 Binnenhalen van NUnit, klink rechts op het project "Programmeren2Opdrachten", en klik vervolgens op Manage NuGetPackage Packages. Zoek naar NUnit en installeer deze package.

* Stap 5 [Nieuw] Je moet ook de Test Adapter van NUnit installeren. Dit doe je als volgt: Tools --> Extensions & Updates --> online --> zoeken naar NUnit --> installeer de Test Adapter van NUnit. Herstart Visual Studio. 

* Stap 6 Bouw het project. Build --> Build Solution of druk op F6
* Stap 7 Begin met het implementeren van de code. 
* Stap 8 Klink rechts in een test methode (te herkennen aan [Test] annotatie). Klink op Run Test. Als het goed is zal de test draaien en de uitkomst wordt zichtbaar in de Test Explorer. Als dit niet gebeurt (Test --> Windows --> TestExplorer).

* Stap 9 Maak de opdrachten. Haal de regel volgende regel weg: 
   throw new NotImplementedException();
  En plaats hier je eigen code. 


### Contribution guidelines ###

* Mocht je fouten tegenkomen, stuur dan even een mailtje of contacteer me even tijdens het college.
* Zelf de test kunnen fouten bevatten! Jullie input is dan ook zeer wenselijk om het materiaal te verbeteren.

### Who do I talk to? ###
 * Joris of Dick