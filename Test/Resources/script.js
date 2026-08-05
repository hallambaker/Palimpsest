var pt8, pt10, pt12, pt14, pt16, pt20, pt24, wnav, wnav0, hpos;

const mainFlow = 420;
const wideNav = 140;
const pad = 10;
const pad2 = pad * 2;
const narrowNav = 20 + pad2;
const formLabels = 100;

var leftOffset, leftWide, rightOffset, rightWide, ppad, ppad2;
var navigation;

function resizeWindow() {

    // document.documentElement.style.setProperty('--color-text', '#e74c3c');
    const element = document.getElementsByTagName('body')[0];

    // console.log(element);

    let w = element.clientWidth;



    // let h = element.outerHeight;
    let p = window.devicePixelRatio;
    let aw = w / p;

    pwideNav = wideNav * p;
    pnarrowNav = narrowNav * p;
    rightWide = mainFlow * p;



    // hamburger.setAttribute.style.display = 'none';

    if (isMobile()) {
        // Display width is fixed so will not need to resize.
    }
    else if (w > pwideNav + rightWide) {
        
        // let labels = formLabels * p;
        // let form = rightWide - labels- 50;
        // // form = 435;
        // document.documentElement.style.setProperty('--form-labels', labels + 'px');
        // document.documentElement.style.setProperty('--form-input', form+'px');

        document.documentElement.style.setProperty('--button-display', 'block');
        document.documentElement.style.setProperty('--hamburger-display', 'none');
        leftWide = pwideNav;
        leftOffset = (w - leftWide - rightWide) / 2;
    }

    else if (w > pnarrowNav + rightWide) {

        // hamburger.setProperty('display', 'none');

        leftWide = narrowNav * p;
        leftOffset = (w - leftWide - rightWide) / 2;
        // document.documentElement.style.setProperty('--form-labels', '30%');
        // document.documentElement.style.setProperty('--form-input', '70%');
        document.documentElement.style.setProperty('--button-display', 'none');
        document.documentElement.style.setProperty('--navigation-display', 'block');
        document.documentElement.style.setProperty('--hamburger-display', 'none');
        // document.documentElement.style.setProperty('--width-navigation', wnav0);
    }
    else {
        // hamburger.setProperty('display', 'none');


        leftWide = 0;
        leftOffset = 0;
        rightWide = w;
        document.documentElement.style.setProperty('--navigation-display', 'none');
        document.documentElement.style.setProperty('--hamburger-display', 'inline');
        // document.documentElement.style.setProperty('--form-labels', '100%');
        // document.documentElement.style.setProperty('--form-input', '100%');
    }

    rightOffset = leftOffset + leftWide;

    // console.log('Wide ' + w + ' ' + p)
    // console.log ('Left '+leftOffset + ' ' + leftWide)
    // console.log('Right ' + rightOffset + ' ' + rightWide)

    document.documentElement.style.setProperty('--left-offset', leftOffset + 'px');
    document.documentElement.style.setProperty('--left-wide', (leftWide - ppad2) + 'px');
    document.documentElement.style.setProperty('--right-offset', rightOffset + 'px');
    document.documentElement.style.setProperty('--right-wide', (rightWide - ppad2) + 'px');
}

function setFullMode() {

    let w = window.outerWidth;



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

// document.documentElement.style.setProperty('--color-text', '#e74c3c');
function initializeDisplay() {
    p = window.devicePixelRatio;
    h = window.innerHeight;
    ppad = pad * p;
    ppad2 = pad2 * p;

    pt8 = (8 * p) + "px";
    pt10 = (10 * p) + "px";
    pt12 = (12 * p) + "px";
    pt14 = (14 * p) + "px";
    pt16 = (16 * p) + "px";
    pt20 = (20 * p) + "px";
    pt24 = (24 * p) + "px";


    wnav = (wideNav * p - ppad) + "px";
    wnav0 = (20 * p - ppad) + "px";
    var hheight = 24 * p ;

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
    document.documentElement.style.setProperty('--header-height', hheight + "px");
    // document.documentElement.style.setProperty('--header-height-pad', (hheight + ppad2) + "px");

    document.documentElement.style.setProperty('--main-pad', ppad + "px");
    document.documentElement.style.setProperty('--window-height', (h-hheight) + 'px');

    let hamburger = document.getElementById("OpenNav");
    hamburger.addEventListener('onclick', openNav);


    // console.log('High ' + hheight);
}

const isMobile = () => {
    // For testing, allow testing of the mobile interaction with destop tools
    // return true;

    // Check if the new API is supported
    if (navigator.userAgentData) {
        return navigator.userAgentData.mobile;
    }

    // Fallback for Safari/Firefox (see Solution 3)
    return /Mobi|Android/i.test(navigator.userAgent);
};

function setNavigation() {
    navigation = document.getElementById("Navigation");
    if (navigation == null) {
        navigation = document.getElementById("SupportNav");
    }

}






function openNav() {
    setNavigation();
    document.documentElement.style.setProperty('--navigation-display', 'block');
    document.getElementById("Navigation").style.width = "240px";
}

function closeNav() {
    setNavigation();
    document.getElementById("Navigation").style.width = "0";
    document.documentElement.style.setProperty('--navigation-display', 'none');
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

// console.log('Hello world');


const element = document.getElementsByTagName('body')[0];
// console.log(element);

element.onresize = resizeWindow;
if (isMobile()) {
    // const element = document.getElementById('root');
    element.classList.add('Mobile');
    window.onscroll = scrollHeader;
    // document.getElementById("mobile").innerHTML = "Mobile";
}
else {
    // document.documentElement.style.setProperty('--color-text', '#e74c3c');
    // const element = document.getElementById('root');
    element.classList.add('Desktop');

    // document.getElementById("mobile").innerHTML = "Desktop";
}



initializeDisplay();
resizeWindow();
previousScrollPosition = window.pageYOffset;