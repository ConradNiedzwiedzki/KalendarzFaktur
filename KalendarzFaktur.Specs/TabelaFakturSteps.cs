using System;
using TechTalk.SpecFlow;

namespace KalendarzFaktur.Specs
{
    [Binding]
    public class TabelaFakturSteps
    {
        [Given(@"uzytkownik uruchomił aplikację")]
        [When(@"uzytkownik uruchomia aplikację")]
        public void GivenUzytkownikUruchomilAplikacje()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"użytkownik otworzył jeden z rekordów tabeli")]
        [When(@"użytkownik otwiera jeden z rekordów tabeli")]
        public void WhenUzytkownikOtwieraJedenZRekordowTabeli()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"rekord tabeli wyświetla się prawidłowo")]
        public void ThenRekordTabeliWyswietlaSiePrawidlowo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
