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
