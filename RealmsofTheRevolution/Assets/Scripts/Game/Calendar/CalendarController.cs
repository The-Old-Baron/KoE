public class CalendarController : ControllerBase
{
    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public Year year;
    public int CurrentDay { get; private set; }
    public int CurrentMonth { get; private set; }
    public int CurrentSeason { get; private set; }

    private Day currentDay;
    private Month currentMonth;
    private Season currentSeason;

    public void StartCalendar(){
        currentDay = year.months[0].days[0];
        currentMonth = year.months[0];
        currentSeason = year.seasons[0];
    }

    public void NextDay()
    {
        CurrentDay++;
        if (CurrentDay > currentMonth.daysInMonth)
        {
            CurrentDay = 0;
            CurrentMonth++;
            if (CurrentMonth > currentSeason.months.Count)
            {
                CurrentMonth = 0;
                CurrentSeason++;
                if (CurrentSeason > year.seasons.Count)
                {
                    CurrentSeason = 0;
                }
            }
        }
    }
}