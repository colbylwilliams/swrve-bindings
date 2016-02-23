#GRADLE=sh /Applications/Android\ Studio.app/Contents/gradle/gradle-2.8/bin/gradle
#ANDROID_HOME=$(HOME)/Library/Developer/Xamarin/android-sdk-macosx

all : android/SwrveSDK-core-release.aar

android/swrve-android-sdk/README.md :
	mkdir -p android
	cd android && git clone git@github.com:Swrve/swrve-android-sdk.git
	cd android/swrve-android-sdk && git checkout 4.2.0
	# cd android/swrve-android-sdk && git submodule update --init --recursive

android/SwrveSDK-core-release.aar : android/swrve-android-sdk/README.md
	cd android/swrve-android-sdk/SwrveSDK && ../gradlew clean build aR # ANDROID_HOME=$(ANDROID_HOME) $(GRADLE) aR
	cp android/swrve-android-sdk/SwrveSDK/build/outputs/aar/SwrveSDK-core-release.aar android/
	cp android/swrve-android-sdk/SwrveSDK/build/outputs/aar/SwrveSDK-google-release.aar android/

clean :
	rm -rf android