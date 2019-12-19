using System;
using System.Collections;
using System.Collections.Generic;

namespace ThemeParkTycoonGame.Core
{
    public class GuestList : IEnumerable<Guest>
    {
        public delegate void GuestAddedEvent(object sender, GuestAddedEventArgs e);
        public event GuestAddedEvent GuestAdded;

        public delegate void GuestRemovedEvent(object sender, GuestRemovedEventArgs e);
        public event GuestRemovedEvent GuestRemoved;

        public List<Guest> Guests;

        public GuestList()
        {
            Guests = new List<Guest>();
        }

        public GuestList(List<Guest> guests)
        {
            Guests = guests;
        }

        public void Add(Guest guest)
        {
            // Set the time entered if not set already
            if (guest.TimeEntered == null)
            {
                guest.TimeEntered = DateTime.Now;
            }

            // Add the guest to the guest list (so we can retrieve them later)
            Guests.Add(guest);

            // Check if someone is handling this event
            if (GuestAdded != null)
            {
                GuestAdded.Invoke(this, new GuestAddedEventArgs(guest));
            }
        }

        public void Clear()
        {
            Guest[] oldGuests = new Guest[this.Guests.Count];
            this.Guests.CopyTo(oldGuests);

            this.Guests.Clear();

            if (GuestRemoved != null)
            {
                foreach (Guest guest in oldGuests)
                {
                    GuestRemoved.Invoke(this, new GuestRemovedEventArgs(guest));
                }
            }
        }

        public void Remove(Guest guest)
        {
            this.Guests.Remove(guest);

            if (GuestRemoved != null)
            {
                GuestRemoved.Invoke(this, new GuestRemovedEventArgs(guest));
            }
        }

        public IEnumerator<Guest> GetEnumerator()
        {
            return ((IEnumerable<Guest>)Guests).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Guest>)Guests).GetEnumerator();
        }
    }

    public class GuestRemovedEventArgs : EventArgs
    {
        public Guest Guest;

        public GuestRemovedEventArgs(Guest guest)
        {
            Guest = guest;
        }
    }

    public class GuestAddedEventArgs : EventArgs
    {
        public Guest Guest;

        public GuestAddedEventArgs(Guest guest)
        {
            Guest = guest;
        }
    }
}