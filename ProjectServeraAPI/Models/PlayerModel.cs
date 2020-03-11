using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectServeraAPI.Models
{
    public class PlayerModel
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _nickname;
        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _birthday;
        public DateTime BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private DateTime _datejoined;
        public DateTime DateJoined
        {
            get { return _datejoined; }
            set { _datejoined = value; }
        }

        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
    }
}