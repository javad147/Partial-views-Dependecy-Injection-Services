using Task.Models;

namespace Task.ViewModels
{
    public class HomeVM
    {
        public SurpriseInfo SurpriseInfo { get; set; }
        public List<SurpriseAdvantage> SurpriseAdvantages { get; set; }
        public SurpriseVideo SurpriseVideo { get; set; }
        public ExpertInfo ExpertInfo { get; set; }
        public List<Specialist> Specialists { get; set; }
        public List<Position> Positions { get; set; }
    }
}
