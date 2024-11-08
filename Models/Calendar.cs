    namespace NascarCalendar.Models;

    public class Calendar
    {
        public List<Race> series_3 { get; set; }
        public List<Race> series_1 { get; set; }
        public List<Race> series_2 { get; set; }
    }

    public class Schedule
    {
        public string event_name { get; set; }
        public string notes { get; set; }
        public DateTime start_time_utc { get; set; }
        public int run_type { get; set; }
    }

    public class Race
    {
        public int race_id { get; set; }
        public int series_id { get; set; }
        public int race_season { get; set; }
        public string race_name { get; set; }
        public int race_type_id { get; set; }
        public bool restrictor_plate { get; set; }
        public int track_id { get; set; }
        public string track_name { get; set; }
        public DateTime date_scheduled { get; set; }
        public DateTime race_date { get; set; }
        public DateTime qualifying_date { get; set; }
        public DateTime tunein_date { get; set; }
        public double scheduled_distance { get; set; }
        public double actual_distance { get; set; }
        public int scheduled_laps { get; set; }
        public int actual_laps { get; set; }
        public int stage_1_laps { get; set; }
        public int stage_2_laps { get; set; }
        public int stage_3_laps { get; set; }
        public int number_of_cars_in_field { get; set; }
        public int pole_winner_driver_id { get; set; }
        public double pole_winner_speed { get; set; }
        public int number_of_lead_changes { get; set; }
        public int number_of_leaders { get; set; }
        public int number_of_cautions { get; set; }
        public int number_of_caution_laps { get; set; }
        public double average_speed { get; set; }
        public string total_race_time { get; set; }
        public string margin_of_victory { get; set; }
        public int race_purse { get; set; }
        public string race_comments { get; set; }
        public int attendance { get; set; }
        public List<object> infractions { get; set; }
        public List<Schedule> schedule { get; set; }
        public string radio_broadcaster { get; set; }
        public string television_broadcaster { get; set; }
        public string satellite_radio_broadcaster { get; set; }
        public int master_race_id { get; set; }
        public bool inspection_complete { get; set; }
        public int playoff_round { get; set; }
        public bool is_qualifying_race { get; set; }
        public int qualifying_race_no { get; set; }
        public int qualifying_race_id { get; set; }
        public bool has_qualifying { get; set; }
        public int winner_driver_id { get; set; }
        public object pole_winner_laptime { get; set; }
    }

