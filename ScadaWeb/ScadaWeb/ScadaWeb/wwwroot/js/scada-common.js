﻿// Contains common JavaScript classes.
// No dependencies.

// Provides helper methods.
class ScadaUtils {
    // The window width that is considered a small.
    static SMALL_WND_WIDTH = 800;

    // Checks if a browser window is small sized, such as a mobile device.
    static get isSmallScreen() {
        return top.innerWidth <= this.SMALL_WND_WIDTH;
    }

    // Checks if browser is in full screen mode switched on programmatically.
    // See https://developer.mozilla.org/en-US/docs/Web/API/Fullscreen_API
    static get isFullscreen() {
        return document.fullscreenElement ||
            document.mozFullScreenElement ||
            document.webkitFullscreenElement ||
            document.msFullscreenElement
            ? true
            : false;
    }

    // Checks if browser is actually in full screen mode.
    static get isActualFullscreen() {
        return screen.height - window.innerHeight <= 1;
    }

    // Switches browser to full screen mode.
    static requestFullscreen() {
        if (document.documentElement.requestFullscreen) {
            document.documentElement.requestFullscreen();
        } else if (document.documentElement.msRequestFullscreen) {
            document.documentElement.msRequestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) {
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullscreen) {
            document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
        }
    }

    // Exits browser full screen mode.
    static exitFullscreen() {
        if (document.exitFullscreen) {
            document.exitFullscreen();
        } else if (document.msExitFullscreen) {
            document.msExitFullscreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitExitFullscreen) {
            document.webkitExitFullscreen();
        }
    }

    // Plays a sound of the audio jQuery object.
    static playSound(jqAudio) {
        if (jqAudio.length > 0) {
            let promise = jqAudio[0].play();
            promise.catch(function (error) {
                console.error("Error playing sound '" + jqAudio.attr("src") + "': " + error);
            });
        }
    }

    // Gets a value with the specified key in the given Storage object.
    static getStorageItem(storage, keyName, opt_defaultValue) {
        try {
            let val = storage.getItem(keyName);
            return val ? val : opt_defaultValue;
        } catch (ex) {
            console.error(ex);
            return opt_defaultValue;
        }
    }

    // Adds or updates the specified key and value in the given Storage object.
    static setStorageItem(storage, keyName, keyValue) {
        try {
            storage.setItem(keyName, keyValue);
        } catch (ex) {
            console.error(ex);
        }
    }
}

// Specifies event types.
class ScadaEventTypes {
    // Notifies controls that the layout should be updated.
    static UPDATE_LAYOUT = "scada:updateLayout";
}