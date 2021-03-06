﻿using BS.Plugin.V3.Output;
using System;

namespace BugShooting.Output.DoneDone
{

  public class Output: IOutput 
  {
    
    string name;
    string url;
    string userName;
    string password;
    string fileName;
    Guid fileFormatID;
    bool openItemInBrowser;
    int lastProjectID;
    int lastPriorityLevelID;
    int lastFixerID;
    int lastTesterID;
    int lastIssueID;

    public Output(string name, 
                  string url, 
                  string userName,
                  string password, 
                  string fileName,
                  Guid fileFormatID,
                  bool openItemInBrowser,
                  int lastProjectID,
                  int lastPriorityLevelID,
                  int lastFixerID,
                  int lastTesterID,
                  int lastIssueID)
    {
      this.name = name;
      this.url = url;
      this.userName = userName;
      this.password = password;
      this.fileName = fileName;
      this.fileFormatID = fileFormatID;
      this.openItemInBrowser = openItemInBrowser;
      this.lastProjectID = lastProjectID;
      this.lastPriorityLevelID = lastPriorityLevelID;
      this.lastFixerID = lastFixerID;
      this.lastTesterID = lastTesterID;
      this.lastIssueID = lastIssueID;
    }
    
    public string Name
    {
      get { return name; }
    }

    public string Information
    {
      get { return url; }
    }

    public string Url
    {
      get { return url; }
    }
       
    public string UserName
    {
      get { return userName; }
    }

    public string Password
    {
      get { return password; }
    }
          
    public string FileName
    {
      get { return fileName; }
    }

    public Guid FileFormatID
    {
      get { return fileFormatID; }
    }

    public bool OpenItemInBrowser
    {
      get { return openItemInBrowser; }
    }
    
    public int LastProjectID
    {
      get { return lastProjectID; }
    }

    public int LastPriorityLevelID
    {
      get { return lastPriorityLevelID; }
    }

    public int LastFixerID
    {
      get { return lastFixerID; }
    }

    public int LastTesterID
    {
      get { return lastTesterID; }
    }

    public int LastIssueID
    {
      get { return lastIssueID; }
    }

  }
}
