Feature: Otwieranie faktur z tabeli
	W celu prawidłowego otwarcia faktury tabeli
	Jako użytkownik
	Chcę prawidłowo wyświetlić jeden z rekordów tabeli

Scenario: Użytkownik wyświetla losowy rekord tabeli
	Given uzytkownik uruchomił aplikację

	When użytkownik otwiera jeden z rekordów tabeli

	Then rekord tabeli wyświetla się prawidłowo
