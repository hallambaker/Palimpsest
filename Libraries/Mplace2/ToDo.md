# To Do list



# Errors

* Delete Post/Comment not working
 Is dying in     protected virtual void DeleteKeys(EarlEntryIndex<T> index) of EarlCatalog

* Check redirect working on delete post / comment

* Show the post/comment being deleted

* Post page, decorate avatar usert wit link to member page

* Comments don't show user

* Disable comment/delete if not authorized






# Release blocking


## Member Page
Allow user to upload an avatar and banner, set name.


##	Separate production/development systems
Kind of not good doing live edits on the public site.

## Terms of service etc.
Fill in pages that are under the Help/About tabs.




# Deferred

## Separate feeds
Allow users to separate their content into separate publication feeds

## Images in posts
Need to fix the post validation first and store 

## Like/Dislike
Enable the like/Dislike buttons.



# Gating allowing others to create places

## Limit place requests per day

## User quotas
Limit posts per user, data per user. Set different quota per user.

##	Rate limits
Should cap use of site to reasonable limits

##	Data limits
Should cap amount of data that can be posted by a given user

## Enable block user/report user
Also mute post/thread/etc.






# Rest

##	Complete OAUTH2 login
Currently, the code is not checking that the handle authenticated is the one expected

##	Moderation
Should allow use of ATmosphere blocklists to block access



## Enable the 'copy link to post' and 'embed link' tools.

## Enable the translate option.




##	Visitor history
Should track visitor history in a per visitor log

##	Private places/topics
Allow users to limit access to their personal places or topics therein

##	Logging
Need to log server activity to a file

##	Docker version
Run under Docker

##	Backup site
Backup site activity to an offsite system

##	Server Status
Report server status, load etc.



##	Weekly status reports
Should have a weekly status report showing number of vistors/posts/etc where they came from, etc.

##	Document updates
Need to be able to replace a document with a new version.

