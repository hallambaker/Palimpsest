var pt8, pt10, pt12, pt14, pt16, pt20, pt24, wnav, wnav0, wmain, hpos;

function resizeWindow() {
    let w = window.outerWidth;
    let h = window.outerHeight;
    let p = window.devicePixelRatio;
    let aw = w / p;

    if (isMobile()) {
    }
    else if (aw > 500) {
        setFullMode();
    }
    else if (aw > 400) {
        setWideMode();
    }
    else {
        setNarrowMode();
    }
}

function setFullMode() {
    document.documentElement.style.setProperty('--width-navigation', wnav);
    document.documentElement.style.setProperty('--button-display', 'block');
}

function setWideMode() {
    document.documentElement.style.setProperty('--width-navigation', wnav0);
    document.documentElement.style.setProperty('--button-display', 'none');
}

function setNarrowMode() {
    document.documentElement.style.setProperty('--width-navigation', wnav0);
    document.documentElement.style.setProperty('--button-display', 'none');
}

function initializeDisplay() {
    p = window.devicePixelRatio;

    pt8 = (8 * p) + "px";
    pt10 = (10 * p) + "px";
    pt12 = (12 * p) + "px";
    pt14 = (14 * p) + "px";
    pt16 = (16 * p) + "px";
    pt20 = (20 * p) + "px";
    pt24 = (24 * p) + "px";


    wnav = (120 * p) + "px";
    wnav0 = (20 * p) + "px";
    wmain = (360 * p) + "px";

    hpos = '-' + pt24;

    document.documentElement.style.setProperty('--pt8', pt8);
    document.documentElement.style.setProperty('--pt10', pt10);
    document.documentElement.style.setProperty('--pt12', pt12);
    document.documentElement.style.setProperty('--pt14', pt14);
    document.documentElement.style.setProperty('--pt16', pt16);
    document.documentElement.style.setProperty('--pt20', pt20);
    document.documentElement.style.setProperty('--pt24', pt24);

    document.documentElement.style.setProperty('--size-h1', pt20);
    document.documentElement.style.setProperty('--size-h2', pt16);
    document.documentElement.style.setProperty('--size-h3', pt12);
    document.documentElement.style.setProperty('--size-icon', pt20);
    document.documentElement.style.setProperty('--size-p', pt12);
    document.documentElement.style.setProperty('--size-c', pt8);

    document.documentElement.style.setProperty('--width-navigation', wnav0);
    document.documentElement.style.setProperty('--header-height', pt20);
}

const isMobile = () => {
    // For testing, allow testing of the mobile interaction with destop tools
    return true;

    // Check if the new API is supported
    if (navigator.userAgentData) {
        return navigator.userAgentData.mobile;
    }

    // Fallback for Safari/Firefox (see Solution 3)
    return /Mobi|Android/i.test(navigator.userAgent);
};

function openNav() {
    document.getElementById("Navigation").style.width = "240px";
}

function closeNav() {
    document.getElementById("Navigation").style.width = "0";
}


var previousScrollPosition = window.pageYOffset;
function scrollHeader() {
    // document.documentElement.style.setProperty('--color-text', '#e74c3c');
    var currentScrollPosition = window.pageYOffset;

    if (previousScrollPosition > currentScrollPosition) {
        document.documentElement.style.setProperty('--header-position', '0');
    }
    else if (previousScrollPosition < currentScrollPosition) {
        document.documentElement.style.setProperty('--header-position', hpos);
    }
    previousScrollPosition = currentScrollPosition;

}


if (isMobile()) {
    const element = document.getElementById('root');
    element.classList.add('Mobile');

    window.onscroll = scrollHeader;
    // document.getElementById("mobile").innerHTML = "Mobile";
}
else {
    const element = document.getElementById('root');
    element.classList.add('Desktop');

    // document.getElementById("mobile").innerHTML = "Desktop";
}



initializeDisplay();
resizeWindow();
previousScrollPosition = window.pageYOffset;