# Spring App

### Running in Development

* Run app and start server on port 8080
`mvn spring-boot:run`

* Open in browser [http://localhost:8080](http://localhost:8080)

### View Production version

* [http://sign-meup.herokuapp.com](http://sign-meup.herokuapp.com)

# Node.js App
 
* Objective: Convert Auslan Video to Text

## Setup 

### Installations and Downloads

#### Download and install ngrok
* Download [https://ngrok.com/download](https://ngrok.com/download)
* Extract `ngrok` executable and copy to a directory in your PATH so can run it from any directory
* Check directories that are in your PATH with `echo $PATH`
* Append /user/local/bin that contains to your $PATH if necessary
`echo 'export PATH=$PATH:/usr/local/bin'  >> ~/.bash_profile`
* Copy it to /usr/local/bin. It can be run with `ngrok`
* Run bot locally using ngrok by running the following in separate terminal window:
`ngrok http 3978`
* Copy the **https** address i.e. `https://ed83c1cd.ngrok.io` (replace `ed83c1cd` with unique value provided by ngrok) for prepending in Bot configuration
* **Important:** Re-Copy and paste this https URL in relevant sections when restart ngrok

### Bot Framework Configuration
* Go to https://dev.botframework.com
* Register New Bot
* Register New App. Copy the App ID/Password
* Click "Add to Skype" to add the Bot to your Skype Client 
* Edit the Bot Configuration. Paste the App ID/Password. Add Messaging Endpoint (ending with **/api/messages**): i.e. `https://ed83c1cd.ngrok.io/api/messages`
* Edit Skype Channel for the Bot. Enable bot, enable messages (text and pictures), and enable group messaging
* Edit Skype Channel for the Bot. Enable calls (activates in up to 24 hrs) and enter for Calling Webhook endpoint for Bot (ending with **/api/calls**): `https://ed83c1cd.ngrok.io/api/calls`
* **Important:** Update the **Calling Webhook** with new https URL when restart ngrok

### Set Environment Variables Locally
* Append environment variables to your $PATH
`echo 'export MICROSOFT_APP_ID="<app-id>"' >> ~/.bash_profile`
`echo 'export MICROSOFT_APP_PASSWORD="<app-password>"' >> ~/.bash_profile`
`echo 'export CALLBACK_URL="https://ed83c1cd.ngrok.io/api/calls"' >> ~/.bash_profile`

* **Important:** Update the **CALLBACK_URL** with new https URL when restart ngrok and repeat these steps

* Check they were added with by running the following for each to see the respective value output:
`echo $MICROSOFT_APP_ID`

* Apply these changes to terminal session
`source ~/.bash_profile`

### Setup Libraries

* Note: BotBuilder SDK is used in this app as a calling and chat bot for Skype

* Install NPM dependencies specific to Bot Builder Core library
`mkdir -p ./node_app/lib/bot_builder/core/node_modules && npm install --prefix ./node_app/lib/bot_builder/core`

* [OPTIONALLY?] Install NPM dependencies specific to Bot Builder Calling library
`mkdir -p ./node_app/lib/bot_builder/calling/node_modules && npm install --prefix ./node_app/lib/bot_builder/calling`

### Setup Libraries

* Install NPM dependencies app from root directory
`mkdir -p ./node_app/node_modules && npm install --prefix ./node_app`

### Run Bot

* Run the app
`node ./node_app/src/app.js`

### Test Bot

* Click "Test connecton to bot" button at [https://dev.botframework.com](https://dev.botframework.com) to test Bot request works. It should return `Accepted`.
The ngrok terminal should update with `POST /api/messages  202 Accepted`

* Send messages in Chat within [https://dev.botframework.com](https://dev.botframework.com) or send via Skype Client app or call the Bot and wait for automated response