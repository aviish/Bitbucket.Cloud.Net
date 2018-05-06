![Icon](https://i.imgur.com/OsDAzyV.png)
# Bitbucket.Net 
[![Build status](https://ci.appveyor.com/api/projects/status/e6syxlce88nlg75d?svg=true)](https://ci.appveyor.com/project/lvermeulen/bitbucket-cloud-net)
 [![license](https://img.shields.io/github/license/lvermeulen/Bitbucket.Cloud.Net.svg?maxAge=2592000)](https://github.com/lvermeulen/Bitbucket.Cloud.Net/blob/master/LICENSE) [![NuGet](https://img.shields.io/nuget/vpre/Bitbucket.Cloud.Net.svg?maxAge=2592000)](https://www.nuget.org/packages/Bitbucket.Cloud.Net/) 
 ![](https://img.shields.io/badge/.net-4.5.2-yellowgreen.svg) ![](https://img.shields.io/badge/netstandard-1.4-yellowgreen.svg)

Client for Bitbucket Cloud

## Features
* [ ] Authentication
	* [ ] OAuth2
	* [ ] App Passwords
	* [X] Basic
* [ ] 1.0
	* [ ] Group Privileges
	* [ ] Groups
	* [ ] Invitations
	* [ ] Privileges
	* [ ] Repositories
		* [ ] Changesets
		* [ ] Deploy Keys
		* [ ] Events
		* [ ] Followers
		* [ ] Issues
		* [ ] Links
		* [ ] Pull Requests
		* [ ] Repository
		* [ ] Services
		* [ ] Src
		* [ ] Wiki
	* [ ] User
	* [ ] Users
		* [ ] Account
		* [ ] Emails
		* [ ] Invitations
		* [ ] OAuth
		* [ ] Privileges
		* [ ] Ssh Keys
	* [ ] Teams
* [ ] 2.0
	* [ ] Addons
		* [ ] Linkers
			* [ ] Linker Key
				* [ ] Values
	* [ ] Hook Events
		* [ ] Subject Type
	* [X] Repositories
		* [ ] User Name
			* [X] Repo Slug
				* [ ] Branch Restrictions
					* [ ] Id
				* [ ] Commit
					* [ ] Node
						* [ ] Approve
						* [ ] Statuses
							* [ ] Build
								* [ ] Key
					* [ ] Revision
					* [ ] Sha
						* [ ] Comments
							* [ ] Comment Id
				* [ ] Commits
					* [ ] Revision
				* [ ] Components
					* [ ] Component Id
				* [ ] Default Reviewers
					* [ ] Target User Name
				* [ ] Diff
					* [ ] Spec
				* [ ] Diffstat
					* [ ] Spec
				* [ ] Downloads
					* [ ] Filename
				* [ ] File History
					* [ ] Node
						* [ ] Path
				* [ ] Forks
				* [ ] Hooks
					* [ ] Uid
				* [ ] Issues
					* [ ] Issue Id
						* [ ] Attachments
							* [ ] Path
						* [ ] Changes
							* [ ] Change Id
						* [ ] Comments
							* [ ] Comment Id
						* [ ] Vote
						* [ ] Watch
				* [ ] Milestones
					* [ ] Milestone Id
				* [ ] Patch
					* [ ] Spec
				* [ ] Pipelines
					* [ ] Pipeline Uuid
						* [ ] Steps
							* [ ] Step Uuid
								* [ ] Log
						* [ ] Stop Pipeline
				* [ ] Pipelines Config
					* [ ] Build Number
					* [ ] Schedules
						* [ ] Schedule Uuid
							* [ ] Executions
					* [ ] Ssh
						* [ ] Key Pair
						* [ ] Known Hosts
							* [ ] Known Host Uuid
					* [ ] Variables
						* [ ] Variable Uuid
				* [ ] Properties
					* [ ] App Key
						* [ ] Property Name
				* [ ] Pull Requests
					* [ ] Activity
					* [ ] Pull Request Id
						* [ ] Activity
						* [ ] Approve
						* [ ] Comments
						* [ ] Commits
						* [ ] Decline
						* [ ] Diff
						* [ ] Diffstat
						* [ ] Merge
						* [ ] Patch
						* [ ] Statuses
				* [ ] Refs
					* [ ] Branches
						* [ ] Name
					* [ ] Tags
						* [ ] Name
				* [ ] Src
					* [ ] Node
						* [ ] Path
				* [ ] Versions
					* [ ] Version Id
				* [ ] Watchers
	* [ ] Snippets
		* [ ] User Name
			* [ ] Encoded Id
				* [ ] Comments
				* [ ] Commits
				* [ ] Watch
				* [ ] Watchers
				* [ ] Node Id
					* [ ] Files
						* [ ] Path
				* [ ] Revision
					* [ ] Diff
					* [ ] Patch
	* [ ] Teams
		* [ ] User Name
			* [ ] Followers
			* [ ] Following
			* [ ] Hooks
				* [ ] Uid
			* [ ] Members
			* [ ] Permissions
				* [ ] Repositories
			* [ ] Pipelines Config
				* [ ] Variables
					* [ ] Variable Uuid
			* [ ] Projects
				* [ ] Project Key
			* [ ] Repositories
			* [ ] Search
				* [ ] Code
	* [X] User
		* [ ] Emails
			* [ ] Email
		* [ ] Permissions
			* [ ] Repositories
			* [ ] Teams
	* [ ] Users
		* [ ] User Name
			* [ ] Followers
			* [ ] Following
			* [ ] Hooks
				* [ ] Uid
			* [ ] Pipelines Config
				* [ ] Variables
					* [ ] Variable Uuid
			* [ ] Repositories
			* [ ] Search
				* [ ] Code
			* [ ] Ssh Keys