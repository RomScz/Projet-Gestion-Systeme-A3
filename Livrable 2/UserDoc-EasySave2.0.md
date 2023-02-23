#Documentation User EasySave2.0

###THE USER INTERFACE

<img src="https://cdn.discordapp.com/attachments/1067811500732993596/1078316617966026842/ManuelUtilisation.png" alt="">

###Log file
* The log file is saved here: `\EasySaveApp\Logs\`

###State file
* The state file is saved here: `\EasySaveApp\bin\Debug\netcoreapp3.1\State\state.json`

###BlackList file
* The blacklist file is located at: `\EasySaveApp\Ressources\BlackList.json`
<p>To fill this file there is a syntax to respect.
<p>It is necessary to separate the software to be banned by a ","
<pre><code>[ 
    { "blacklisted_items": "calculator,notepad" } 
]</code></pre>

###File of extensions to be encrypted
* The file of the extensions to be encrypted is located at: `\EasySaveApp\Ressources\CryptExtension.json`
<p>To fill this file there is a syntax to respect.
<p>It is necessary to separate the software to be banned by a ","
<pre><code>[
  { "extension_to_crypt": ".txt,.csv" }
]</code></pre>
