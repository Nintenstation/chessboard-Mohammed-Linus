# chessboard-Mohammed-Linus
Chessboard rendering for C#

The requirement to run the program is .NET 10.0 installed and the Pastel package version 8.0.0. The program runs in its respective folder 
and can be executed through a CLI-app (Power shell or Windows console) or through .EXE inside the map. If you want to install through git 
you need to have git installed on your computer.

If you install the program from a console, Github HTTPS-link is used that can be located inside “Code”. Copy the link and open the console 
and choose the map you want to install the program in. Write “git clone” and paste the link and press Enter. The map with the program is 
now installed. Then you go into the folder with the same name as the Github repo and choose the Chessboard map (cd <map_name> command).
Then you can test run the program by writing “dotnet run” in the console while you are inside the map. If you have the correct .NET version 
the program should start and run.

Application: The Program asks the user how big the chessboard should be. If the user writes 6 the program will print out a chessboard with 
6 rows and 6 columns. If the user writes a letter, a number lower than 3 or higher than 50 the program will flag wrong input and asks the user to 
try again. When the user input a valid number the program will print out a chessboard. It is achieved by a modulo operator in a nestled 
for-loop that implements a binary logic.

The NugGet package that has been added is “Pastel” version 8.0.0. It is an easy, popular and trustworthy package. It is used to put 
colour on different strings when the program is running. It is added to make it easier to spot changes in the program. For example if the 
user writes a non valid input the text will be red and if the user writes a valid input the text will be green. Additionally the chessboard 
is printed in black and white colors and all of this is done to make it easier for the user to view the chessboard and to identify when an 
invalid input has been entered. 

The program features a modular code structure that breaks down different methods into smaller building blocks to keep the source code 
organized and easy to navigate. The project consists of two class files. The program divides the user input and error handling into two 
separate methods within the Program class, where execution begins in the Main method. The second and longer method is responsible for 
rendering the chessboard and is located in a separate class file the BoardRendering class and is a static method that can be called from 
the Main method without creating an object. The methods in the Program class return values, while the static method in BoardRendering.cs 
accepts a parameter corresponding to the users requested size.

In summary, the technical choices in our program were made not only to organize the code, but also to make execution more efficient. The 
chessboard logic relies on a form of binary logic, as there are only two possible outcomes when printing the chessboard - the square is 
either white or black. The nested for-loop is used not only to construct the rows and columns of squares, but also to identify the position 
of the square currently being printed. A modulo operator % 2 combined with an if-statement ensures the result is strictly 0 or 1. If the 
result is 0, a black square is printed, and if it is 1, a white square is printed.

----------------

Projektet är ett enkelt C#-program som renderar ett schackbräde i konsolen. Användaren kan ange storleken på brädet, och programmet kommer att generera en visuell representation av schackbrädet med hjälp av tecken.

Projektet körs mestadels i en nestlad for-loop, där den yttre loopen skapar rader och den inre loopen skapar kolumner. Modulo-operatorn används för att växla mellan de två tecknen som representerar de olika rutorna på brädet.
Programmet innehåller även felhantering vid inmatning som görs bland annat med TryParse() och while-loopar.

Kraven för att köra programmet är att ha .NET 10.0 installerad på datorn samt Pastel paketet i version 8.0.0. Programmet ska köras i
dess respektive mapp, och kan exekveras genom en CLI-app (som powershell eller windows terminal) eller genom .EXE inuti mappen med dess binära filer.
Om du vill installera genom git kommando så behöver du också ha git installerat i datorn.

Om du ska installera programmet igenom en terminal så används Github HTTPS-länken som man hittar inuti "Code". Kopiera länken och öppna terminalen och välj mappen
du vill installera programmet i. Skriv "git clone" och sedan klistra in länken och klick på Enter. Mappen med programmet har nu installerats.
Sedan går du in i mappen med samma namn som Github repon och väljer att gå in i Chessboard mappen (det gör du genom cd <mappnamn> kommando).
Sedan testar du med att köra programmet genom att skriva "dotnet run". Om den korrekta version av .NET är installerat bör programmet köras.

Användning: Programmet ber om användaren att de ska ange hur stor schackbrädet ska vara, i både höjd och bas. Inmatningen är baserat på hur många kvadrat som finns,
så skriver användaren "6" ska den vara 6 kvadrater långt och 6 kvadrater brett. Använader kan inte heller skriva in exempelvis text eller 
nummer som är mindre 3 eller större än 50, annars kommer programmet notera fel inmatning och be användaren att ange rimligt tal igen. När
användaren har angett rätt inmatning så kommer shackbrädet att skrivas ut, där varenda kvadrat är svart eller vit. Det uppnås genom en 
modulo operator i en nestlad for-loop som implementerar en binär logik.

Paketet som har lagts till är "Pastel package" version 8.0.0. Det är en enkel, känd och pålitlig paket på Nuget library som färgar olika 
strängar när programmet körs. Anledningen varför detta har valts är att göra det lättare att märka en förändring i programmet. Exempelvis
om användare skriver fel så skriver det ut röd text, gentemot grön text när inget sker fel. Dessutom skrivs schackbrädet ut i svart och
vit färg. Allt det här görs så att användaren kan lättare se inte bara schackbrädet, men när de har angett fel eller att det finns exempelvis
en inmatning.

Programmet har en modulär kodstruktur som delar in olika metoder i mindre byggstenar, så att källkoden ska se organiserad ut och lättare
att navigera. Projektet innehåller två klassfiler. Programmet delar in själva inmatningen och felhantering genom två respektive metoder 
i Program-klassen, där programmet börjar att köras i main-metoden. Den andra och längre metoden för att skriva ut shackbrädet befinner sig 
i en annan klassfil, BoardRendering-klassen, och är en statisk metod som kan anropas i Main metoden utan att skapa objekt. 
Metoderna i Program-klassen returnerar värden, och den statiska metoden i BoardRendering.cs tar emot en parameter, som är vad användaren
har angett för önskad storlek på schackbrädet.

För att sammanfatta kort, så har de tekniska valen i vårt program använts för att inte bara organisera koden men göra hanteringen mer 
effektivt. Logiken för schackbrädet är en form av binär logik eftersom det finns endast två val när schackbrädet skrivs ut - antingen
så är kvadraten vit eller svart. Den nestlade for-loopen används för att inte bara bygga rad och kolumner av kvadrat, men också att 
identifiera vilken plats den nuvarande kvadraten som skrivs ut befinner sig i. Då används en modulo-operator med 2 och en if-sats, så att
resultateten blir endast 0 eller 1. Om den är 0 skrivs ut en svart kvadrat, om den är 1 skrivs ut en vit kvadrat.

//skriv om git
