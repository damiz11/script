var footer = webpackJsonp_name_([ 3 ], {
39: function(t, e, n) {
"use strict";
var o = n(559), i = n(561), r = n(562);
!function() {
o(), window.devicePixelRatio > 1 && i(), window.addEventListener("scroll", r), r();
for (var t = document.querySelectorAll(".auto-currency"), e = 0; e < t.length; e++) {
var n = t[e], a = Math.round(parseInt(n.innerHTML) / window.rateUsdRub);
n.insertAdjacentHTML("beforeEnd", '<span class="auto-currency__usd">(≈' + a + "$)</span>");
}
}();
},
559: function(t, e, n) {
"use strict";
var o = n(560);
t.exports = function() {
function t(t) {
var e = t.clientX + r;
e + i.offsetWidth > document.documentElement.clientWidth && (e = Math.max(0, t.clientX - r - i.offsetWidth)), 
i.style.left = e + "px";
var n = t.clientY + a;
n + i.offsetHeight > document.documentElement.clientHeight && (n = Math.max(0, t.clientY - a - i.offsetHeight)), 
i.style.top = n + "px";
}
function e(e) {
if (e.target.closest) {
var n = e.target.closest("a, [data-tooltip]");
n && ("A" == n.tagName && n.closest(".toolbar") || (i = document.createElement("span"), 
i.className = "link__type", n.getAttribute("data-tooltip") ? i.setAttribute("data-tooltip", n.getAttribute("data-tooltip")) : i.setAttribute("data-url", n.getAttribute("href")), 
document.body.appendChild(i), t(e), document.addEventListener("mousemove", t)));
}
}
function n() {
i && (document.removeEventListener("mousemove", t), i.remove(), i = null);
}
var i = null, r = 8, a = 10;
o("a,[data-tooltip]", e, n);
};
},
560: function(t, e, n) {
"use strict";
function o(t, e, n) {
f[t] = {
over: e,
out: n
};
}
function i(t) {
if (!l) {
if (Math.sqrt(Math.pow(t.pageX - s, 2) + Math.pow(t.pageY - c, 2)) / (Date.now() - u) < d) {
var e = document.elementFromPoint(t.clientX, t.clientY);
if (!e) return;
if (e != a) {
for (var n in f) {
var o = e.closest(n);
o && (l = {
elem: o,
out: f[n].out
}, f[n].over(t));
}
a = e;
}
}
s = t.pageX, c = t.pageY, u = Date.now();
}
}
function r(t) {
if (l) {
for (var e = t.relatedTarget; e; ) {
if (e == l.elem) return;
e = e.parentElement;
}
var n = l.out;
l = null, n(t);
}
}
var a, l, s = 1 / 0, c = 1 / 0, u = Date.now(), d = .2, f = {};
document.addEventListener("mousemove", i), document.addEventListener("mouseout", r), 
t.exports = o;
},
561: function(t, e, n) {
"use strict";
t.exports = function() {
for (var t = document.querySelectorAll('figure img[src$=".png"]'), e = 0; e < t.length; e++) !function() {
var n = t[e];
n.onload = function() {
if (this.onload = null, !this.src.match(/@2x.png$/)) {
var t = new Image();
t.onload = function() {
this.width && this.height && (n.src = this.src);
}, t.src = this.src.replace(".png", "@2x.png");
}
}, n.complete && n.onload();
}();
};
},
562: function(t, e, n) {
"use strict";
function o() {
for (var t = document.querySelectorAll("[data-sticky]"), e = 0; e < t.length; e++) {
var n = t[e], o = n.dataset.sticky ? document.querySelector(n.dataset.sticky) : document.body;
if (n.getBoundingClientRect().top < 0) {
if (n.style.cssText) return;
var r = n.getBoundingClientRect().left, a = i(n);
n.parentNode.insertBefore(a, n), o.appendChild(n), n.classList.add("sticky"), n.style.position = "fixed", 
n.style.top = 0, n.style.left = r + "px", n.style.zIndex = 101, n.style.background = "white", 
n.style.margin = 0, n.style.width = a.offsetWidth + "px", n.placeholder = a;
} else n.placeholder && n.placeholder.getBoundingClientRect().top > 0 && (n.style.cssText = "", 
n.classList.remove("sticky"), n.placeholder.parentNode.insertBefore(n, n.placeholder), 
n.placeholder.remove(), n.placeholder = null);
}
}
function i(t) {
var e = document.createElement("div"), n = getComputedStyle(t);
return e.style.width = t.offsetWidth + "px", e.style.marginLeft = n.marginLeft, 
e.style.marginRight = n.marginRight, e.style.height = t.offsetHeight + "px", e.style.marginBottom = n.marginBottom, 
e.style.marginTop = n.marginTop, e;
}
t.exports = o;
}
}, [ 39 ]);