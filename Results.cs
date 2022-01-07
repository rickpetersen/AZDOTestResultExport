    public class Rootobject
    {
        public int count { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public Configuration configuration { get; set; }
        public Project project { get; set; }
        public DateTime startedDate { get; set; }
        public DateTime completedDate { get; set; }
        public float durationInMs { get; set; }
        public string outcome { get; set; }
        public int revision { get; set; }
        public string state { get; set; }
        public Testcase testCase { get; set; }
        public Testpoint testPoint { get; set; }
        public Testrun testRun { get; set; }
        public DateTime lastUpdatedDate { get; set; }
        public int priority { get; set; }
        public DateTime createdDate { get; set; }
        public string url { get; set; }
        public string failureType { get; set; }
        public string testCaseTitle { get; set; }
        public int testCaseRevision { get; set; }
        public object[] customFields { get; set; }
        public Testplan testPlan { get; set; }
        public int testCaseReferenceId { get; set; }
        public Owner owner { get; set; }
        public Runby runBy { get; set; }
        public Lastupdatedby lastUpdatedBy { get; set; }
    }

    public class Configuration
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Testcase
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Testpoint
    {
        public string id { get; set; }
    }

    public class Testrun
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Testplan
    {
        public string id { get; set; }
    }

    public class Owner
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public _Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class _Links
    {
        public Avatar avatar { get; set; }
    }

    public class Avatar
    {
        public string href { get; set; }
    }

    public class Runby
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public _Links1 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class _Links1
    {
        public Avatar1 avatar { get; set; }
    }

    public class Avatar1
    {
        public string href { get; set; }
    }

    public class Lastupdatedby
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public _Links2 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class _Links2
    {
        public Avatar2 avatar { get; set; }
    }

    public class Avatar2
    {
        public string href { get; set; }
    }