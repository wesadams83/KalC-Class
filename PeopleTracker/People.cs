using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleTracker
{
    enum TypeOfPeople
    {
        Client,
        TeamMember,
        Friend
    }
    class People
    {
        #region Properties
        public string PeopleName { get; set; }
        public DateTime CreateDate { get; }
        public string EmailAddress { get; set; }
        public TypeOfPeople PeopleType { get; set; }
        public DateTime BirthDate { get; set; }
        #endregion

        #region Constructors

        public People()
        {
            CreateDate = DateTime.UtcNow;
        }

        #endregion

        #region Methods

        #endregion
    }
}
