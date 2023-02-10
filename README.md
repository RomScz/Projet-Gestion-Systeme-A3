#titre EasySave

This project is called **EasySave**, you will find all the different version in this repository. 

--------------------------------------------------------------------------------------

Livrable 0 Description: Work Environment
Your team must install a work environment that respects the constraints imposed by ProSoft.

The proper use of the work environment and the constraints imposed by management will be evaluated throughout the project.

A particular vigilance will be carried on :

- GIT management (versioning)

- UML diagrams to be returned 24 hours before each deliverable (Milestone)

- Code quality (absence of redundancy in the lines of code)

 --------------------------------------------------------------------------------------

Description of livrable 1 : EasySave version 1.0
The specifications of the first version of the software are as follows:

- The software is a Console application using .Net Core.

- The software must allow to create up to 5 backup jobs

A backup job is defined by :

- A name

- A source directory

- A target directory

- A type (full, differential)

The software must be usable at least by English and French speaking users

The user can request the execution of one of the backup jobs or the sequential execution of all the jobs.

The directories (source and target) can be on :

- Local disks

- External disks

- Network drives

- All the elements of the source directory are concerned by the backup

Daily log file:

The software must write in real time in a daily log file the history of the actions of the backup jobs. The minimum information expected is:

- Timestamp

- Name of the backup job

- Complete address of the source file (UNC format)

- Full address of the destination file (UNC format)

- Size of the file

- File transfer time in ms (negative if error)


The software must record in real time, in a single file, the progress of the backup jobs. The information to be recorded for each backup job is :

- Name of the backup job

- Timestamp

- Status of the backup job (e.g.: Active, Not active, etc.)

If the job is active:

- The total number of eligible files

- The size of the files to be transferred

- The progress

- Number of files remaining

- Size of remaining files

- Full address of the source file being backed up

- Full address of the destination file


The locations of the two files (daily log and state) will have to be studied to work on the clients' servers. Therefore, locations such as "c:\temp\" should be avoided.

The files (daily log and status) and any configuration files will be in JSON format. To allow a fast reading via Notepad, it is necessary to put line breaks between the JSON elements. A pagination would be a plus.
