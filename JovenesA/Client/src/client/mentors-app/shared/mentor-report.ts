 export class RptMentorReport {
      constructor(
        public MentorReportId?: number,
        public mentorId?: number,
        public studentId?: number,
        public mentorName?: string,
        public studentName?: string,
        public reportDateTime?: Date,
        public LastContactDate?: Date,
        public MentorReportSnapshot?: number,
        public ReasonForDelay?: string,
        public FollowUpNeeded?: string,
        public RecentSuccess?: string,
        public RecentSetback?: string
      ) {

      }
    }

 export class MentorReport {
      constructor(
        public MentorReportId?: number,
        public mentorId?: number,
        public studentId?: number,
        public reportDateTime?: Date,
        public lastContactDate?: Date,
        public mentorReportSnapshot?: number,
        public reasonForDelay?: string,
        public followUpNeeded?: string,
        public recentSuccess?: string,
        public recentSetback?: string
      ) {

      }
    }
