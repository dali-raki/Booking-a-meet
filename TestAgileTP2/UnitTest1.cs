using Agile2TP2.Models;
using Agile2TP2.Services;

namespace TestAgileTP2
{
    public class Tests
    {
        private BokingService _bokingService;
        private BokingModel meet;
        [SetUp]
        public void Setup()
        {
            _bokingService = new BokingService();
        }

        [TestCase(-1)]
        [TestCase(30)]
        [TestCase(25)]
        [TestCase(0)]
        public void CheckHeur(int Heur)
        {
            meet = new BokingModel("raki",Heur, "212", "2023-11-15T14:30:00");
            List<BokingModel> listmeet = new List<BokingModel>();
            var check = _bokingService.IsBookingConflict(listmeet, meet);
            Assert.AreEqual(true,check);
        }



        [Test]
        public void Checkinput()
        {
            meet = new BokingModel("",2, "", "2023-11-15T14:30:00");



        }


    }
}