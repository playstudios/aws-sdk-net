## Add Specific unity editor dlls here

You need at least UnityEngine.dll. It can be found in /Applications/Unity/Hub/Editor/2019.2.21f1/Unity/Contents/Managed/UnityEngine.dll

## Modify various csproj to reference the proper UnityEngine.dll

Need to modify the following three csproj files to point to the proper UnityEngine.dll

* sdk/src/Core/AWSSDK.Core.Unity.csproj
* sdk/src/Services/CognitoSync/AWSSDK.CognitoSync.Unity.csproj
* sdk/src/Services/MobileAnalytics/AWSSDK.MobileAnalytics.Unity.csproj

## How to compile

* Open sdk/AWSSDK.Unity.sln in Rider
* Change configuration to Release
* Click on Build -> Build Solution
* Once completed, copy the following dlls to Unity Project
  * sdk/src/Services/CognitoIdentity/bin/Release/unity/AWSSDK.CognitoIdentity.dll -> Slots/unity/Assets/AWSSDK/AWSSDK.CognitoIdentity.dll
  * sdk/src/Services/CognitoIdentity/bin/Release/unity/AWSSDK.Core.dll -> Slots/unity/Assets/AWSSDK/AWSSDK.Core.dll
  * sdk/src/Services/CognitoIdentity/bin/Release/unity/AWSSDK.SecurityToken.dll -> Slots/unity/Assets/AWSSDK/AWSSDK.SecurityToken.dll
  * sdk/src/Services/KinesisFirehose/bin/Release/unity/AWSSDK.KinesisFirehose.dll -> Slots/unity/Assets/AWSSDK/AWSSDK.KinesisFirehose.dll
