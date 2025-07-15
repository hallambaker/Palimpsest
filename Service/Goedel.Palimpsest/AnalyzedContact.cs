#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
#endregion

namespace Goedel.Palimpsest;

public record AnalyzedContact {
    public string Handle { get; set; } = null;
    public string Earl { get; set; } = null;


    public string FullName { get; } = null;

    public JsContact JsContact { get; set; } = null;

    public List<AnalyzedService> Services = [];

    public string ContactDownload = "jscontact";

    public AnalyzedContact(
            JsContact contact) {

        if (contact is null) {
            return;
            }
        JsContact = contact;

        FullName = contact.Name?.Full;

        AddService(ContactConstant.OnlineServiceMail);
        AddService(ContactConstant.OnlineServiceWeb);
        AddService(ContactConstant.OnlineServiceSsh);
        AddService(ContactConstant.OnlineServiceGit);
        AddService(ContactConstant.OnlineServiceMesh);
        AddService(ContactConstant.OnlineServiceGroup);
        AddService(ContactConstant.OnlineServiceCredential);

        }


    void AddService(
                string id) {
        var service = new AnalyzedService(JsContact, id);
        if (service.Entries.Count > 0) {
            Services.Add(service);
            }
        }

    }


public record AnalyzedService {

    public string Service { get;  } = null;
    public List<AnalyzedEntry> Entries{ get; } = [];

    public AnalyzedService(
        JsContact contact,
        string serviceId) {

        Service = serviceId;

        if (serviceId == ContactConstant.OnlineServiceMail) {
            foreach (var email in contact.Emails.IfEnumerable()) {
                Entries.Add(new AnalyzedEntryMail(contact, email.Value));
                }
            }
        else {
            foreach (var service in contact.OnlineServices.IfEnumerable()) {
                if (service.Value.Service == serviceId) {
                    Entries.Add(new AnalyzedEntryService(contact, service.Value));
                    }
                }
            }


        }

    public void AddMail(JsContact contact) {


        }


    }

public record AnalyzedEntry {

    public AnalyzedEntry() {
        }
    }

public record AnalyzedEntryMail : AnalyzedEntry {
    public EmailAddress EmailAddress { get; }

    public string DownloadOpenPgp { get; } = null;
    public string DownloadSmime { get; } = null;
    public AnalyzedEntryMail(JsContact contact, EmailAddress email) {
        EmailAddress = email;
        }

    }

public record AnalyzedEntryService : AnalyzedEntry {



    public OnlineService OnlineService { get; }
    
    public string Title { get; }
    public string Uri { get; }

    public string DownloadTag { get; } = null;


    public AnalyzedEntryService(JsContact contact, OnlineService service) {
        OnlineService = service;

        Title = service.Uri ?? "Key";
        Uri = service.Uri;


        switch (service.Service) {
            case ContactConstant.OnlineServiceMesh:
            case ContactConstant.OnlineServiceGit:
            case ContactConstant.OnlineServiceSsh: {
                DownloadTag = "ToBeSpecified";
                break;
                }

            }
        
        }

    }


public record AnalyzedEntryServiceWeb : AnalyzedEntryService {

    public OnlineService OnlineService { get; }
    public AnalyzedEntryServiceWeb(JsContact contact, OnlineService service) : base (contact,service){
        OnlineService = service;
        }

    }

