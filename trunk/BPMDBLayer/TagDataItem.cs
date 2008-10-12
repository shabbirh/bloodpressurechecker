using System;

namespace Hassanally.Net.XMLDataLayer
{
    
    public class TagDataItem
    {
        private DateTime m_date;
        private long m_lPKId;
        private int m_nDiastolic;
        private int m_nEvent;
        private int m_nHeartRate;
        private int m_nSystolic;
        private string m_strDescription;

        public TagDataItem()
        {
            this.ID = 0L;
            this.Date = DateTime.Now;
            this.Systolic = 0;
            this.Diastolic = 0;
            this.HeartRate = 0;
            this.Event = 0;
            this.Description = "";
        }

        public DateTime Date
        {
            get
            {
                return this.m_date;
            }
            set
            {
                this.m_date = value;
            }
        }

        public string Description
        {
            get
            {
                return this.m_strDescription;
            }
            set
            {
                this.m_strDescription = value;
            }
        }

        public int Diastolic
        {
            get
            {
                return this.m_nDiastolic;
            }
            set
            {
                this.m_nDiastolic = value;
            }
        }

        public int Event
        {
            get
            {
                return this.m_nEvent;
            }
            set
            {
                this.m_nEvent = value;
            }
        }

        public int HeartRate
        {
            get
            {
                return this.m_nHeartRate;
            }
            set
            {
                this.m_nHeartRate = value;
            }
        }

        public long ID
        {
            get
            {
                return this.m_lPKId;
            }
            set
            {
                this.m_lPKId = value;
            }
        }

        public int Systolic
        {
            get
            {
                return this.m_nSystolic;
            }
            set
            {
                this.m_nSystolic = value;
            }
        }
    }
}

