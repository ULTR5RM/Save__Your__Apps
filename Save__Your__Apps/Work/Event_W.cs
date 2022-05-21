using Save__Your__Apps.Connection;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Work
{
    public class Event_W
    {
       
            public static void AddEvent(EventType type, string app)
            {
                Event ev = new Event(type, App_W.IdentityToId(app));
                using (Event_C db = new Event_C())
                {
                    db.Add(ev);
                    db.SaveChanges();
                }
            }
            public static List<Event> GetEventList(string Identity)
            {
                List<Event> eventsList = new List<Event>();

                int oid = App_W.IdentityToId(Identity);

                using (Event_C db = new Event_C())
                {
                    foreach (Event entry in db.Events.Where(b => b.App == oid))
                    {
                        eventsList.Add(entry);
                    }
                }
                return eventsList;
            }
            //public static List<Event> GetEventList(string Identity, EventType ET)
            //{
            //    List<Event> eventsList = new List<Event>();

            //    int oid = App_W.IdentityToId(Identity);

            //    using (Event_C db = new Event_C())
            //    {
            //        foreach (Event entry in db.Events.Where(b => b.App == oid).Where(b => b.EventType == ET))
            //        {
            //            eventsList.Add(entry);
            //        }
            //    }
            //    return eventsList;
            //}
            //public static List<Event> GetEventList(string Identity, EventType ET, int days)
            //{
            //    if (days <= -1)
            //    {
            //        return GetEventList(Identity, ET);
            //    }

            //    List<Event> eventsList = new List<Event>();

            //    int oid = App_W.IdentityToId(Identity);

            //    using (Event_C db = new Event_C())
            //    {
            //        foreach (Event entry in db.Events.Where(b => b.App == oid).Where(b => b.EventType == ET).Where(b => b.DateCreated >= DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).AddDays(-days)))
            //        {
            //            eventsList.Add(entry);
            //        }
            //    }
            //    return eventsList;
            //}
            //public static List<Event> GetEventList(string Identity, int days)
            //{
            //    if (days <= -1)
            //    {
            //        return GetEventList(Identity);
            //    }

            //    List<Event> eventsList = new List<Event>();

            //    int oid = App_W.IdentityToId(Identity);

            //    using (Event_C db = new Event_C())
            //    {
            //        foreach (Event entry in db.Events.Where(b => b.App == oid).Where(b => b.DateCreated >= DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc).AddDays(-days)))
            //        {
            //            eventsList.Add(entry);
            //        }
            //    }
            //    return eventsList;
            //}

    }
}
