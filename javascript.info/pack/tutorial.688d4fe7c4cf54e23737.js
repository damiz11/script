var tutorial = webpackJsonp_name_([ 5 ], {
100: function(e, t) {
!function(e) {
e.languages.ruby = e.languages.extend("clike", {
comment: [ /#(?!\{[^\r\n]*?\}).*/, /^=begin(?:\r?\n|\r)(?:.*(?:\r?\n|\r))*?=end/m ],
keyword: /\b(?:alias|and|BEGIN|begin|break|case|class|def|define_method|defined|do|each|else|elsif|END|end|ensure|false|for|if|in|module|new|next|nil|not|or|raise|redo|require|rescue|retry|return|self|super|then|throw|true|undef|unless|until|when|while|yield)\b/
});
var t = {
pattern: /#\{[^}]+\}/,
inside: {
delimiter: {
pattern: /^#\{|\}$/,
alias: "tag"
},
rest: e.util.clone(e.languages.ruby)
}
};
e.languages.insertBefore("ruby", "keyword", {
regex: [ {
pattern: /%r([^a-zA-Z0-9\s{(\[<])(?:(?!\1)[^\\]|\\[\s\S])*\1[gim]{0,3}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%r\((?:[^()\\]|\\[\s\S])*\)[gim]{0,3}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%r\{(?:[^#{}\\]|#(?:\{[^}]+\})?|\\[\s\S])*\}[gim]{0,3}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%r\[(?:[^\[\]\\]|\\[\s\S])*\][gim]{0,3}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%r<(?:[^<>\\]|\\[\s\S])*>[gim]{0,3}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /(^|[^\/])\/(?!\/)(\[.+?]|\\.|[^\/\\\r\n])+\/[gim]{0,3}(?=\s*($|[\r\n,.;})]))/,
lookbehind: !0,
greedy: !0
} ],
variable: /[@$]+[a-zA-Z_]\w*(?:[?!]|\b)/,
symbol: /:[a-zA-Z_]\w*(?:[?!]|\b)/
}), e.languages.insertBefore("ruby", "number", {
builtin: /\b(?:Array|Bignum|Binding|Class|Continuation|Dir|Exception|FalseClass|File|Stat|Fixnum|Float|Hash|Integer|IO|MatchData|Method|Module|NilClass|Numeric|Object|Proc|Range|Regexp|String|Struct|TMS|Symbol|ThreadGroup|Thread|Time|TrueClass)\b/,
constant: /\b[A-Z]\w*(?:[?!]|\b)/
}), e.languages.ruby.string = [ {
pattern: /%[qQiIwWxs]?([^a-zA-Z0-9\s{(\[<])(?:(?!\1)[^\\]|\\[\s\S])*\1/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%[qQiIwWxs]?\((?:[^()\\]|\\[\s\S])*\)/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%[qQiIwWxs]?\{(?:[^#{}\\]|#(?:\{[^}]+\})?|\\[\s\S])*\}/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%[qQiIwWxs]?\[(?:[^\[\]\\]|\\[\s\S])*\]/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /%[qQiIwWxs]?<(?:[^<>\\]|\\[\s\S])*>/,
greedy: !0,
inside: {
interpolation: t
}
}, {
pattern: /("|')(?:#\{[^}]+\}|\\(?:\r\n|[\s\S])|(?!\1)[^\\\r\n])*\1/,
greedy: !0,
inside: {
interpolation: t
}
} ];
}(Prism);
},
101: function(e, t) {
Prism.languages.java = Prism.languages.extend("clike", {
keyword: /\b(?:abstract|continue|for|new|switch|assert|default|goto|package|synchronized|boolean|do|if|private|this|break|double|implements|protected|throw|byte|else|import|public|throws|case|enum|instanceof|return|transient|catch|extends|int|short|try|char|final|interface|static|void|class|finally|long|strictfp|volatile|const|float|native|super|while)\b/,
number: /\b0b[01]+\b|\b0x[\da-f]*\.?[\da-fp\-]+\b|\b\d*\.?\d+(?:e[+-]?\d+)?[df]?\b/i,
operator: {
pattern: /(^|[^.])(?:\+[+=]?|-[-=]?|!=?|<<?=?|>>?>?=?|==?|&[&=]?|\|[|=]?|\*=?|\/=?|%=?|\^=?|[?:~])/m,
lookbehind: !0
}
}), Prism.languages.insertBefore("java", "function", {
annotation: {
alias: "punctuation",
pattern: /(^|[^.])@\w+/,
lookbehind: !0
}
});
},
18: function(module, exports, __webpack_require__) {
"use strict";
function init() {
initTaskButtons(), initMoreEnContentButton(), initFolderList(), initSidebarHighlight(), 
initRuNewsletterForm(), initEnSubscribeButton(), delegate(document, '[data-action="tutorial-map"]', "click", function(e) {
1 == e.which && (e.preventDefault(), showTutorialMapModal());
}), prism.init(), window.ebookType && __webpack_require__.e(6).then(function() {
__webpack_require__(663).init();
}.bind(null, __webpack_require__)).catch(__webpack_require__.oe);
var e = document.querySelector(".tutorial-map");
e ? new TutorialMap(e) : /[&?]map\b/.test(location.href) && showTutorialMapModal();
}
function initRuNewsletterForm() {
var e = document.querySelector("[data-newsletter-subscribe-form]");
e && (e.onsubmit = function(t) {
t.preventDefault(), newsletter.submitSubscribeForm(e);
});
}
function initEnSubscribeButton() {
var e = document.querySelector(".main-en-banner__subscribe");
e && newsletter.initEnSubscribeButton(e);
}
function showTutorialMapModal() {
/[&?]map\b/.test(location.href) || window.history.replaceState(null, null, ~location.href.indexOf("?") ? location.href + "&map" : location.href + "?map"), 
new TutorialMapModal().elem.addEventListener("tutorial-map-remove", function() {
window.history.replaceState(null, null, location.href.replace(/[&?]map\b/, ""));
});
}
function initMoreEnContentButton() {
var e = document.getElementsByClassName("list-sub__more");
if (e.length) for (var t = 0; t < e.length; t++) e[t].addEventListener("click", function() {
for (var e = this.parentElement.querySelectorAll(".list-sub__item.list-sub__item_phone_hidden"), t = 0; t < e.length; t++) e[t].className = "list-sub__item", 
this.style.display = "none";
});
}
function initSidebarHighlight() {
function e() {
var e = document.getElementsByClassName("sidebar__navigation-link_active");
e[0] && e[0].classList.remove("sidebar__navigation-link_active");
for (var t = document.getElementsByTagName("h2"), n = 0; n < t.length; n++) {
if (t[n].getBoundingClientRect().top > 1) break;
}
if (--n >= 0) {
var r = t[n].firstElementChild && t[n].firstElementChild.getAttribute("href"), a = document.querySelector('.sidebar__navigation-link a[href="' + r + '"]');
r && a && a.classList.add("sidebar__navigation-link_active");
}
}
document.addEventListener("DOMContentLoaded", function() {
e(), window.addEventListener("scroll", e);
});
}
function initTaskButtons() {
delegate(document, ".task__solution", "click", function(e) {
var t = e.target.closest(".task");
t.classList.toggle("task_answer_open");
var n = t.querySelector(".task__answer");
n.getBoundingClientRect().bottom > document.documentElement.clientHeight && window.scrollBy(0, Math.min(200, n.getBoundingClientRect().bottom - document.documentElement.clientHeight));
}), delegate(document, ".task__answer-close", "click", function(e) {
e.target.closest(".task").classList.toggle("task_answer_open");
}), delegate(document, ".task__step-show", "click", function(e) {
e.target.closest(".task__step").classList.toggle("task_step_open");
});
}
function initFolderList() {
delegate(document, ".lessons-list__lesson_level_1 > .lessons-list__link", "click", function(e) {
var t = e.delegateTarget, n = t.closest(".lessons-list").querySelector(".lessons-list__lesson_open");
n && n != t.parentNode && n.classList.remove("lessons-list__lesson_open"), t.parentNode.classList.toggle("lessons-list__lesson_open"), 
e.preventDefault();
});
}
var delegate = __webpack_require__(524), prism = __webpack_require__(616), xhr = __webpack_require__(531), TutorialMapModal = __webpack_require__(661), TutorialMap = __webpack_require__(662), newsletter = __webpack_require__(543);
window.runDemo = function(button) {
for (var demoElem, parent = button; (parent = parent.parentElement) && !(demoElem = parent.querySelector("[data-demo]")); ) ;
demoElem ? eval(demoElem.textContent) : alert("Error, no demo element");
}, init();
},
4: function(e, t, n) {
function r(e) {
return n(a(e));
}
function a(e) {
var t = i[e];
if (!(t + 1)) throw Error("Cannot find module '" + e + "'.");
return t;
}
var i = {
"./en.yml": 669,
"./ru.yml": 670
};
r.keys = function() {
return Object.keys(i);
}, r.resolve = a, e.exports = r, r.id = 4;
},
531: function(e, t, n) {
"use strict";
function r(e) {
function t(e, t) {
var n = new CustomEvent(e);
return n.originalEvent = t, n;
}
function n(e, n) {
var r = t("fail", n);
r.reason = e, a.dispatchEvent(r);
}
function r(e, n) {
var r = t("success", n);
r.result = e, a.dispatchEvent(r);
}
var a = new XMLHttpRequest(), s = e.method || "GET", l = e.body, c = e.url;
a.open(s, c, !e.sync), a.method = s;
var u = i();
u && !e.skipCsrf && a.setRequestHeader("X-XSRF-TOKEN", u), "[object Object]" == {}.toString.call(l) && (a.setRequestHeader("Content-Type", "application/json;charset=UTF-8"), 
l = JSON.stringify(l)), e.noDocumentEvents || (a.addEventListener("loadstart", function(e) {
a.timeStart = Date.now();
var n = t("xhrstart", e);
document.dispatchEvent(n);
}), a.addEventListener("loadend", function(e) {
var n = t("xhrend", e);
document.dispatchEvent(n);
}), a.addEventListener("success", function(e) {
var n = t("xhrsuccess", e);
n.result = e.result, document.dispatchEvent(n);
}), a.addEventListener("fail", function(e) {
var n = t("xhrfail", e);
n.reason = e.reason, document.dispatchEvent(n);
})), e.raw || a.setRequestHeader("Accept", "application/json"), a.setRequestHeader("X-Requested-With", "XMLHttpRequest");
var d = e.normalStatuses || [ 200 ];
return a.addEventListener("error", function(e) {
n(o("site.errors.server_connection_error"), e);
}), a.addEventListener("timeout", function(e) {
n(o("site.errors.server_request_timeout"), e);
}), a.addEventListener("abort", function(e) {
n(o("site.errors.request_aborted"), e);
}), a.addEventListener("load", function(t) {
if (!a.status) return void n(o("site.errors.no_response"), t);
if (-1 == d.indexOf(a.status)) return void n(o("site.errors.server_error", {
status: response.status
}), t);
var i = a.responseText;
if (a.getResponseHeader("Content-Type").match(/^application\/json/) || e.json) try {
i = JSON.parse(i);
} catch (t) {
return void n(o("site.errors.invalid_format"), t);
}
r(i, t);
}), setTimeout(function() {
a.send(l);
}, 0), a;
}
var a = n(523), i = n(532), s = n(537).lang, o = n(538);
o.requirePhrase("site", n(1)("./" + s + ".yml")), document.addEventListener("xhrfail", function(e) {
new a.Error(e.reason);
}), e.exports = r;
},
532: function(e, t, n) {
"use strict";
e.exports = function() {
var e = document.cookie.match(/XSRF-TOKEN=([\w-]+)/);
return e ? e[1] : null;
};
},
533: function(e, t, n) {
"use strict";
function r(e) {
return null != e && "" !== e;
}
function a(e) {
return (Array.isArray(e) ? e.map(a) : e && "object" === (void 0 === e ? "undefined" : o(e)) ? Object.keys(e).filter(function(t) {
return e[t];
}) : [ e ]).filter(r).join(" ");
}
function i(e) {
return l[e] || e;
}
function s(e) {
var t = (e + "").replace(c, i);
return t === "" + e ? e : t;
}
var o = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function(e) {
return typeof e;
} : function(e) {
return e && "function" == typeof Symbol && e.constructor === Symbol && e !== Symbol.prototype ? "symbol" : typeof e;
};
t.merge = function e(t, n) {
if (1 === arguments.length) {
for (var a = t[0], i = 1; i < t.length; i++) a = e(a, t[i]);
return a;
}
var s = t.class, o = n.class;
(s || o) && (s = s || [], o = o || [], Array.isArray(s) || (s = [ s ]), Array.isArray(o) || (o = [ o ]), 
t.class = s.concat(o).filter(r));
for (var l in n) "class" != l && (t[l] = n[l]);
return t;
}, t.joinClasses = a, t.cls = function(e, n) {
for (var r = [], i = 0; i < e.length; i++) n && n[i] ? r.push(t.escape(a([ e[i] ]))) : r.push(a(e[i]));
var s = a(r);
return s.length ? ' class="' + s + '"' : "";
}, t.style = function(e) {
return e && "object" === (void 0 === e ? "undefined" : o(e)) ? Object.keys(e).map(function(t) {
return t + ":" + e[t];
}).join(";") : e;
}, t.attr = function(e, n, r, a) {
return "style" === e && (n = t.style(n)), "boolean" == typeof n || null == n ? n ? " " + (a ? e : e + '="' + e + '"') : "" : 0 == e.indexOf("data") && "string" != typeof n ? (JSON.stringify(n).indexOf("&"), 
n && n.toISOString, " " + e + "='" + JSON.stringify(n).replace(/'/g, "&apos;") + "'") : r ? (n && n.toISOString, 
" " + e + '="' + t.escape(n) + '"') : (n && n.toISOString, " " + e + '="' + n + '"');
}, t.attrs = function(e, n) {
var r = [], i = Object.keys(e);
if (i.length) for (var s = 0; s < i.length; ++s) {
var o = i[s], l = e[o];
"class" == o ? (l = a(l)) && r.push(" " + o + '="' + l + '"') : r.push(t.attr(o, l, !1, n));
}
return r.join("");
};
var l = {
"&": "&amp;",
"<": "&lt;",
">": "&gt;",
'"': "&quot;"
}, c = /[&<>"]/g;
t.escape = s, t.rethrow = function e(t, r, a, i) {
if (!(t instanceof Error)) throw t;
if (!("undefined" == typeof window && r || i)) throw t.message += " on line " + a, 
t;
try {
i = i || n(78).readFileSync(r, "utf8");
} catch (n) {
e(t, null, a);
}
var s = 3, o = i.split("\n"), l = Math.max(a - s, 0), c = Math.min(o.length, a + s), s = o.slice(l, c).map(function(e, t) {
var n = t + l + 1;
return (n == a ? "  > " : "    ") + n + "| " + e;
}).join("\n");
throw t.path = r, t.message = (r || "Jade") + ":" + a + "\n" + s + "\n\n" + t.message, 
t;
}, t.DebugItem = function(e, t) {
this.lineno = e, this.filename = t;
};
},
534: function(e, t, n) {
"use strict";
function r(e) {
e.bem = a, e.t = o, e.thumb = i, e.lang = s;
}
var a = n(535)(), i = n(536).thumb, s = n(537).lang, o = n(538);
e.exports = function(e, t) {
return t = t ? Object.create(t) : {}, r(t), e(t);
};
},
535: function(e, t, n) {
"use strict";
var r = n(533);
e.exports = function(e) {
function t(e, t, n, a, i) {
var s = i || "div";
switch (s) {
case "img":
n.alt && !n.title && (n.title = ""), n.title && !n.alt && (n.alt = n.title), n.alt || (n.alt = "");
break;

case "input":
n.type || (n.type = "text");
break;

case "html":
e.push("<!DOCTYPE HTML>");
break;

case "a":
n.href || (n.href = "#");
}
e.push("<" + s + r.attrs(r.merge([ n ]), !0) + ">"), t && t(), -1 == [ "area", "base", "br", "col", "embed", "hr", "img", "input", "keygen", "link", "menuitem", "meta", "param", "source", "track", "wbr" ].indexOf(s) && e.push("</" + s + ">");
}
return e = e || {}, e.prefix = e.prefix || "", e.element = e.element || "__", e.modifier = e.modifier || "_", 
function(n, r, a, i) {
var s = this.block, o = this.attributes || {};
if (!o.class && a && !i) throw Error("Block without class: " + a);
if (o.class) {
var l = o.class;
l instanceof Array && (l = l.join(" ")), l = l.split(" ");
var c;
try {
c = l[0].match(RegExp("^(((?!" + e.element + "|" + e.modifier + ").)+)"))[1];
} catch (e) {
throw Error("Incorrect bem class: " + l[0]);
}
i ? l[0] = r[r.length - 1] + e.element + l[0] : r[r.length] = c;
var u = (i ? r[r.length - 1] + e.element : "") + c;
-1 === l.indexOf(u) && (l[l.length] = u);
for (var d = 0; d < l.length; d++) {
var p = l[d];
p.match(RegExp("^(?!" + e.element + ")" + e.modifier)) ? l[d] = u + p : p.match(RegExp("^" + e.element)) && (r[r.length - 2] ? l[d] = r[r.length - 2] + p : l[d] = r[r.length - 1] + p), 
l[d].match(RegExp("^" + u + "($|(?=" + e.element + "|" + e.modifier + "))")) && (l[d] = e.prefix + l[d]);
}
o.class = l.sort().join(" ");
}
t(n, s, o, r, a), i || r.pop();
};
};
},
536: function(e, t, n) {
"use strict";
t.thumb = function(e, t, n) {
if (!e) return e;
var r = window.devicePixelRatio;
t *= r, n *= r;
var a = t <= 160 && n <= 160 ? "t" : t <= 320 && n <= 320 ? "m" : t <= 640 && n <= 640 ? "i" : t <= 1024 && n <= 1024 ? "h" : "";
return e.slice(0, e.lastIndexOf(".")) + a + e.slice(e.lastIndexOf("."));
};
},
543: function(e, t, n) {
"use strict";
function r(e, t) {
if (e.elements.email.value) {
var n = e.elements.slug, r = [];
if (n.length) for (var a = 0; a < n.length; a++) {
var l = n[a];
l.checked && r.push(l.value);
} else r.push(n.value);
if (!r.length) return void new o.Error(c("newsletter.client.choose_newsletter"));
var u = {
email: e.elements.email.value,
slug: r
}, d = s({
method: "POST",
url: e.action,
body: u
}), p = e.querySelector('[type="submit"]'), m = new i({
elem: p,
size: "small",
elemClass: "button_loading"
});
m.start(), p.disabled = !0, d.addEventListener("loadend", function() {
m.stop(), p.disabled = !1;
});
var h = e.getAttribute("data-newsletter-subscribe-form");
d.addEventListener("success", function(n) {
200 == this.status ? (h && (window.metrika.reachGoal("NEWSLETTER-SUBSCRIBE", {
form: h
}), window.ga("send", "event", "newsletter", "subscribe", h)), new o.Success(n.result.message, "slow"), 
e.elements.email.value = "", t && t()) : (window.metrika.reachGoal("NEWSLETTER-SUBSCRIBE-FAIL", {
form: h
}), window.ga("send", "event", "newsletter", "subscribe-fail", h), new o.Error(n.result.message));
});
}
}
function a(e) {
e.addEventListener("click", function() {
return new l({
onSubmit: r
});
});
}
var i = n(526), s = n(531), o = n(523), l = n(666), c = n(538), u = n(537).lang;
c.requirePhrase("newsletter.client", n(4)("./" + u + ".yml")), t.submitSubscribeForm = r, 
t.initEnSubscribeButton = a;
},
562: function(e, t, n) {
"use strict";
function r() {
for (var e = document.querySelectorAll("[data-sticky]"), t = 0; t < e.length; t++) {
var n = e[t], r = n.dataset.sticky ? document.querySelector(n.dataset.sticky) : document.body;
if (n.getBoundingClientRect().top < 0) {
if (n.style.cssText) return;
var i = n.getBoundingClientRect().left, s = a(n);
n.parentNode.insertBefore(s, n), r.appendChild(n), n.classList.add("sticky"), n.style.position = "fixed", 
n.style.top = 0, n.style.left = i + "px", n.style.zIndex = 101, n.style.background = "white", 
n.style.margin = 0, n.style.width = s.offsetWidth + "px", n.placeholder = s;
} else n.placeholder && n.placeholder.getBoundingClientRect().top > 0 && (n.style.cssText = "", 
n.classList.remove("sticky"), n.placeholder.parentNode.insertBefore(n, n.placeholder), 
n.placeholder.remove(), n.placeholder = null);
}
}
function a(e) {
var t = document.createElement("div"), n = getComputedStyle(e);
return t.style.width = e.offsetWidth + "px", t.style.marginLeft = n.marginLeft, 
t.style.marginRight = n.marginRight, t.style.height = e.offsetHeight + "px", t.style.marginBottom = n.marginBottom, 
t.style.marginTop = n.marginTop, t;
}
e.exports = r;
},
616: function(e, t, n) {
"use strict";
function r(e) {
for (var t = e.querySelectorAll(".code-example:not([data-prism-done])"), n = 0; n < t.length; n++) {
var r = t[n];
new s(r), r.setAttribute("data-prism-done", "1");
}
}
function a(e) {
for (var t = e.querySelectorAll("div.code-tabs:not([data-prism-done])"), n = 0; n < t.length; n++) new o(t[n]), 
t[n].setAttribute("data-prism-done", "1");
}
function i(e) {
r(e), a(e);
}
(document.currentScript || [].slice.call(document.getElementsByTagName("script")).pop()).setAttribute("data-manual", 1), 
n(87), n(88), n(89), n(90), n(91), n(92), n(93), n(94), n(95), n(96), n(97), n(98), 
n(99), n(100), n(101), Prism.tokenTag = "code";
var s = n(617), o = n(620);
t.init = function() {
document.removeEventListener("DOMContentLoaded", Prism.highlightAll), document.addEventListener("DOMContentLoaded", function() {
i(document);
});
}, t.highlight = i;
},
617: function(e, t, n) {
"use strict";
function r(e) {
function t() {
var e = y.contentWindow;
if ("function" != typeof e.postMessage) return void alert("Извините, запуск кода требует более современный браузер");
e.postMessage(f, "https://lookatcode.com/showjs");
}
function n() {
var t;
if (w && e.hasAttribute("data-refresh") && (w.remove(), w = null), w || (w = e.querySelector(".code-result")), 
w) t = w.querySelector("iframe"); else {
if (w = document.createElement("div"), w.className = "code-result code-example__result", 
t = document.createElement("iframe"), t.name = "frame-" + Math.random(), t.className = "code-result__iframe", 
"0" === e.getAttribute("data-demo-height")) w.style.display = "none"; else if (e.hasAttribute("data-demo-height")) {
var n = +e.getAttribute("data-demo-height");
t.style.height = n + "px";
}
w.appendChild(t), e.appendChild(w);
}
if (E) {
var r = t.contentDocument || t.contentWindow.document;
r.open(), r.write(d(f)), r.close(), "epub" == window.ebookType && setTimeout(function() {
[].forEach.call(r.querySelectorAll("script"), function(e) {
e.remove();
});
}, 2e3), e.hasAttribute("data-demo-height") || s.iframe(t), S && e.hasAttribute("data-autorun") || o(w) || w.scrollIntoView(!1);
} else {
var a = document.createElement("form");
a.style.display = "none", a.method = "POST", a.enctype = "multipart/form-data", 
a.action = "https://lookatcode.com/showhtml", a.target = t.name;
var i = document.createElement("textarea");
i.name = "code", i.value = d(f), a.appendChild(i), t.parentNode.insertBefore(a, t.nextSibling), 
a.submit(), a.remove(), S && e.hasAttribute("data-autorun") || (t.onload = function() {
e.hasAttribute("data-demo-height") || s.iframe(t), o(w) || w.scrollIntoView(!1);
});
}
}
function r(e) {
var t = document.createElement("script");
t.text = e, document.head.appendChild(t).parentNode.removeChild(t);
}
function c() {
if (e.hasAttribute("data-global")) {
v || (v = document.createElement("iframe"), v.className = "js-frame", v.style.width = 0, 
v.style.height = 0, v.style.border = "none", v.name = "js-global-frame", document.body.appendChild(v));
var n = document.createElement("form");
n.style.display = "none", n.method = "POST", n.enctype = "multipart/form-data", 
n.action = "https://lookatcode.com/showhtml", n.target = "js-global-frame";
var a = document.createElement("textarea");
a.name = "code", a.value = d("<script>\n" + f + "\n<\/script>"), n.appendChild(a), 
v.parentNode.insertBefore(n, v.nextSibling), n.submit(), n.remove();
} else if (E) {
if (e.hasAttribute("data-autorun")) return void r(f);
if (e.hasAttribute("data-domeval")) {
var i = document.createElement("script");
i.text = f, document.head.appendChild(i).parentNode.removeChild(i);
} else try {
window.eval.call(window, f);
} catch (e) {
alert("Error: " + e.message);
}
} else e.hasAttribute("data-refresh") && y && (y.remove(), y = null), y ? t() : (y = document.createElement("iframe"), 
y.className = "js-frame", y.src = "https://lookatcode.com/showjs", y.style.width = 0, 
y.style.height = 0, y.style.border = "none", y.onload = function() {
t();
}, document.body.appendChild(y));
}
function u() {
var e;
if (b) e = d(f); else {
e = "<!DOCTYPE html>\n<html>\n\n<body>\n  <script>\n" + f.replace(/^/gim, "    ") + "\n  <\/script>\n</body>\n\n</html>";
}
var t = document.createElement("form");
t.action = "http://plnkr.co/edit/?p=preview", t.method = "POST", t.target = "_blank", 
document.body.appendChild(t);
var n = document.createElement("textarea");
n.name = "files[index.html]", n.value = e, t.appendChild(n);
var r = document.createElement("input");
r.name = "description", r.value = "Fork from " + window.location, t.appendChild(r), 
t.submit(), t.remove();
}
function d(e) {
var t = e.toLowerCase(), n = t.match(/<body\b/i), r = t.match(/<\/body>/i), a = t.match(/<html>/i), i = t.match(/<\/html>/i);
if (t.match(/^\s*<!doctype/)) return e;
var s = e;
return a || (s = "<html>\n" + s), i || (s += "\n</html>"), n || (s = s.replace("<html>", '<html>\n<head>\n  <meta charset="utf-8">\n</head><body>\n')), 
r || (s = s.replace("</html>", "\n</body>\n</html>")), s = "<!DOCTYPE HTML>\n" + s;
}
function p() {
g ? c() : n(), S = !1;
}
var m = e.querySelector("pre"), h = m.querySelector("code"), f = h.textContent;
Prism.highlightElement(h), l(m), a(m, e.getAttribute("data-highlight-block")), i(m, e.getAttribute("data-highlight-inline"));
var g = m.classList.contains("language-javascript"), b = m.classList.contains("language-markup"), E = +e.getAttribute("data-trusted");
!+e.getAttribute("data-no-strict") && g && (f = "'use strict';\n" + f);
var y, v, w, S = !0;
if (g || b) {
var T = e.querySelector('[data-action="run"]');
T && (T.onclick = function() {
return this.blur(), p(), !1;
});
var k = e.querySelector('[data-action="edit"]');
k && (k.onclick = function() {
return this.blur(), u(), !1;
}), e.hasAttribute("data-autorun") && ("epub" == window.ebookType && "no-epub" == e.getAttribute("data-autorun") ? e.querySelector("iframe").remove() : setTimeout(p, 100));
}
}
function a(e, t) {
if (t) for (var n, r = t.replace(/\s+/g, "").split(","), a = 0; n = r[a++]; ) {
n = n.split("-");
var i = +n[0], s = +n[1] || i, o = '<code class="block-highlight" data-start="' + i + '" data-end="' + s + '">' + Array(i + 1).join("\n") + '<code class="mask">' + Array(s - i + 2).join("\n") + "</code></code>";
e.insertAdjacentHTML("afterBegin", o);
}
}
function i(e, t) {
var n = e.querySelector('code[class*="language-"]');
t = t ? t.split(",") : [];
for (var r = 0; r < t.length; r++) {
var a = t[r].split(":"), i = +a[0], s = a[1].split("-"), o = +s[0], l = +s[1], c = '<code class="inline-highlight">' + Array(i + 1).join("\n") + Array(o + 1).join(" ") + '<code class="mask">' + Array(l - o + 1).join(" ") + "</code></code>";
n.insertAdjacentHTML("afterBegin", c);
}
}
var s = n(571), o = n(618), l = n(619);
e.exports = r;
},
618: function(e, t, n) {
"use strict";
function r(e) {
var t = e.getBoundingClientRect(), n = 0;
if (t.top < 0) n = t.bottom; else {
if (!(t.bottom > window.innerHeight)) return !0;
n = window.innerHeight - top;
}
return n > 10;
}
e.exports = r;
},
619: function(e, t, n) {
"use strict";
function r(e) {
var t, n = 1 + e.innerHTML.split("\n").length, r = Array(n);
r = r.join("<span></span>"), t = document.createElement("span"), t.className = "line-numbers-rows", 
t.innerHTML = r, e.hasAttribute("data-start") && (e.style.counterReset = "linenumber " + +e.dataset.start - 1), 
e.appendChild(t);
}
e.exports = r;
},
620: function(e, t, n) {
"use strict";
function r(e) {
window.ebookType || (this.elem = e, this.translateX = 0, this.switchesElem = e.querySelector("[data-code-tabs-switches]"), 
this.switchesElemItems = this.switchesElem.firstElementChild, this.arrowLeft = e.querySelector("[data-code-tabs-left]"), 
this.arrowRight = e.querySelector("[data-code-tabs-right]"), this.arrowLeft.onclick = function(e) {
e.preventDefault(), this.translateX = Math.max(0, this.translateX - this.switchesElem.offsetWidth), 
this.renderTranslate();
}.bind(this), this.arrowRight.onclick = function(e) {
e.preventDefault(), this.translateX = Math.min(this.translateX + this.switchesElem.offsetWidth, this.switchesElemItems.offsetWidth - this.switchesElem.offsetWidth), 
this.renderTranslate();
}.bind(this), this.delegate(".code-tabs__switch", "click", this.onSwitchClick));
}
var a = n(524), i = n(619);
r.prototype.onSwitchClick = function(e) {
e.preventDefault();
for (var t, n = e.delegateTarget.parentNode.children, r = this.elem.querySelector("[data-code-tabs-content]").children, a = 0; a < n.length; a++) {
var i = n[a], s = r[a];
i == e.delegateTarget ? (t = a, s.classList.add("code-tabs__section_current"), i.classList.add("code-tabs__switch_current")) : (s.classList.remove("code-tabs__section_current"), 
i.classList.remove("code-tabs__switch_current"));
}
0 === t ? this.elem.classList.add("code-tabs_result_on") : (this.elem.classList.remove("code-tabs_result_on"), 
this.highlightTab(r[t]));
}, r.prototype.highlightTab = function(e) {
if (!e.highlighted) {
var t = e.querySelector("pre"), n = t.querySelector("code");
Prism.highlightElement(n), i(t), e.highlighted = !0;
}
}, r.prototype.renderTranslate = function() {
this.switchesElemItems.style.transform = "translateX(-" + this.translateX + "px)", 
0 === this.translateX ? this.arrowLeft.setAttribute("disabled", "") : this.arrowLeft.removeAttribute("disabled"), 
this.translateX === this.switchesElemItems.offsetWidth - this.switchesElem.offsetWidth ? this.arrowRight.setAttribute("disabled", "") : this.arrowRight.removeAttribute("disabled");
}, a.delegateMixin(r.prototype), e.exports = r;
},
661: function(e, t, n) {
"use strict";
function r() {
var e = this;
this.elem = document.createElement("div"), document.body.appendChild(this.elem);
var t = new s({
hasClose: !1
}), n = new o();
t.setContent(n.elem), n.start(), this.onDocumentKeyDown = this.onDocumentKeyDown.bind(this);
var r = a({
url: "/tutorial/map"
});
r.addEventListener("success", function(n) {
t.remove(), e.elem.innerHTML = '<div class="tutorial-map-overlay"></div>', e.mapElem = e.elem.firstChild, 
e.mapElem.innerHTML = n.result + '<button class="close-button tutorial-map-overlay__close"></button>', 
e.mapElem.addEventListener("click", function(t) {
t.target.classList.contains("tutorial-map-overlay__close") && e.remove();
}), document.addEventListener("keydown", e.onDocumentKeyDown), document.body.classList.add("tutorial-map_on"), 
e.mapElem.addEventListener("scroll", c), new l(e.mapElem.firstElementChild);
}), r.addEventListener("fail", function() {
return t.remove();
});
}
var a = n(531), i = n(524), s = n(529), o = n(526), l = n(662), c = n(562);
i.delegateMixin(r.prototype), r.prototype.remove = function() {
this.elem.dispatchEvent(new CustomEvent("tutorial-map-remove")), this.elem.remove(), 
document.body.classList.remove("tutorial-map_on"), document.removeEventListener("keydown", this.onDocumentKeyDown);
}, r.prototype.onDocumentKeyDown = function(e) {
27 == e.keyCode && (e.preventDefault(), this.remove());
}, e.exports = r;
},
662: function(e, t, n) {
"use strict";
function r(e) {
var t = this;
this.elem = e, this.showTasksCheckbox = e.querySelector("[data-tutorial-map-show-tasks]"), 
this.showTasksCheckbox.checked = +localStorage.showTasksCheckbox, this.updateShowTasks(), 
this.showTasksCheckbox.onchange = this.updateShowTasks.bind(this), this.filterInput = this.elem.querySelector("[data-tutorial-map-filter]"), 
this.textInputBlock = this.elem.querySelector(".tutorial-map__filter .text-input"), 
this.filterInput.oninput = this.onFilterInput.bind(this), this.filterInput.onkeydown = this.onFilterKeydown.bind(this), 
this.elem.querySelector(".text-input__clear").onclick = function() {
t.filterInput.value = "", t.showClearButton(!1), t.filter("");
}, this.chaptersCollapsed = JSON.parse(localStorage.tutorialMapChapters || "{}"), 
this.showChaptersCollapsed(), this.delegate(".tutorial-map__item > .tutorial-map__link", "click", function(e) {
e.preventDefault();
var t = e.delegateTarget.getAttribute("href");
this.chaptersCollapsed[t] ? delete this.chaptersCollapsed[t] : this.chaptersCollapsed[t] = 1, 
localStorage.tutorialMapChapters = JSON.stringify(this.chaptersCollapsed), this.showChaptersCollapsed();
});
var n = this.elem.querySelector('.tutorial-map-list-three__link[href="' + location.pathname + '"]');
n && n.classList.add("tutorial-map-list-three__link_active"), this.filterInput.focus();
}
function a(e, t) {
for (var n = 0, r = 0; n < e.length && r < t.length; ) e[n] == t[r] ? (n++, r++) : n++;
return r == t.length;
}
var i = n(575), s = n(524);
r.prototype.showChaptersCollapsed = function() {
for (var e = this.elem.querySelectorAll(".tutorial-map__item > .tutorial-map__link"), t = 0; t < e.length; t++) {
var n = e[t];
this.chaptersCollapsed[n.getAttribute("href")] ? n.parentNode.classList.add("tutorial-map__item_collapsed") : n.parentNode.classList.remove("tutorial-map__item_collapsed");
}
}, r.prototype.updateShowTasks = function() {
this.showTasksCheckbox.checked ? this.elem.classList.add("tutorial-map_show-tasks") : this.elem.classList.remove("tutorial-map_show-tasks"), 
localStorage.showTasksCheckbox = this.showTasksCheckbox.checked ? "1" : "0";
}, r.prototype.onFilterInput = function(e) {
this.showClearButton(e.target.value), this.throttleFilter(e.target.value);
}, r.prototype.onFilterKeydown = function(e) {
27 == e.keyCode && (this.filterInput.value = "", this.showClearButton(!1), this.filter(""));
}, r.prototype.showClearButton = function(e) {
e ? this.textInputBlock.classList.add("text-input_clear-button") : this.textInputBlock.classList.remove("text-input_clear-button");
}, r.prototype.focus = function() {
this.elem.tabIndex = -1, this.elem.focus();
}, r.prototype.filter = function(e) {
function t(t) {
return a(t.querySelector("a").innerHTML.toLowerCase(), e.replace(/\s/g, ""));
}
e = e.toLowerCase();
for (var n = this.showTasksCheckbox.checked, r = (this.elem.querySelectorAll(".tutorial-map-list a"), 
this.elem.querySelectorAll(".tutorial-map-list-two__item")), i = 0; i < r.length; i++) {
var s = r[i], o = s.querySelectorAll(".tutorial-map-list-three__item"), l = Array.prototype.reduce.call(o, function(e, r) {
var a = !1;
if (n) {
var i = r.querySelectorAll(".tutorial-map-list-four__item");
a = Array.prototype.reduce.call(i, function(e, n) {
var r = t(n);
return n.hidden = !r, e || r;
}, !1);
}
var s = a || t(r);
return r.hidden = !s, e || s;
}, !1);
s.hidden = !(l || t(s));
}
}, r.prototype.throttleFilter = i(r.prototype.filter, 200), s.delegateMixin(r.prototype), 
e.exports = r;
},
666: function(e, t, n) {
"use strict";
function r(e, t) {
if (!(e instanceof t)) throw new TypeError("Cannot call a class as a function");
}
function a(e, t) {
if (!e) throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
return !t || "object" != typeof t && "function" != typeof t ? e : t;
}
function i(e, t) {
if ("function" != typeof t && null !== t) throw new TypeError("Super expression must either be null or a function, not " + typeof t);
e.prototype = Object.create(t && t.prototype, {
constructor: {
value: e,
enumerable: !1,
writable: !0,
configurable: !0
}
}), t && (Object.setPrototypeOf ? Object.setPrototypeOf(e, t) : e.__proto__ = t);
}
var s = function() {
function e(e, t) {
for (var n = 0; n < t.length; n++) {
var r = t[n];
r.enumerable = r.enumerable || !1, r.configurable = !0, "value" in r && (r.writable = !0), 
Object.defineProperty(e, r.key, r);
}
}
return function(t, n, r) {
return n && e(t.prototype, n), r && e(t, r), t;
};
}(), o = n(529), l = n(534), c = n(667), u = function(e) {
function t(e) {
r(this, t);
var n = a(this, (t.__proto__ || Object.getPrototypeOf(t)).call(this, e));
n.options = e || {}, n.options.inModal = !0;
var i = document.createElement("div");
return i.innerHTML = l(c, n.options), n.setContent(i), n.elem.querySelector('[type="email"]').focus(), 
n.elem.querySelector("form").addEventListener("submit", n.onFormSubmit.bind(n)), 
n;
}
return i(t, e), s(t, [ {
key: "onFormSubmit",
value: function(e) {
e.preventDefault(), this.options.onSubmit(e.target, this.remove.bind(this));
}
} ]), t;
}(o);
e.exports = u;
},
667: function(e, t, n) {
var r = n(533);
e.exports = function(e) {
var t, n = [], a = {}, i = e || {};
return function(e, i) {
n.push(""), i || (i = []), a.b = t = function(t, r, a) {
this && this.block, this && this.attributes;
e.call(this, n, i, t, r, a);
}, a.e = t = function(e) {
var t = this && this.block, n = this && this.attributes || {};
a.b.call({
block: function() {
t && t();
},
attributes: r.merge([ n ])
}, e, !0);
}, a.b.call({
block: function() {
a.e.call({
block: function() {
n.push("Tell me about major updates");
},
attributes: {
class: "header"
}
}, "h3"), a.e.call({
block: function() {
n.push("We are working on new articles and tutorials. Provide an email to learn about major updates when they happen:");
},
attributes: {
class: "description"
}
}), a.e.call({
block: function() {
a.e.call({
attributes: {
type: "email",
name: "email",
placeholder: "Your email",
required: !0,
class: "input"
}
}, "input"), n.push('<input type="hidden" name="slug" value="javascript-info-updates">'), 
a.e.call({
block: function() {
a.e.call({
block: function() {
n.push("Notify me");
},
attributes: {
class: "text"
}
}, "span");
},
attributes: {
type: "submit",
name: "type",
class: "button button"
}
}, "button");
},
attributes: {
method: "POST",
action: "/newsletter/subscribe",
class: "subscribe-form"
}
}, "form");
},
attributes: {
class: "en-subscribe-form"
}
});
}.call(this, "bem" in i ? i.bem : "undefined" != typeof bem ? bem : void 0, "bem_chain" in i ? i.bem_chain : "undefined" != typeof bem_chain ? bem_chain : void 0), 
n.join("");
};
},
669: function(e, t) {
e.exports = {
choose_newsletter: "Choose newsletters in the list."
};
},
670: function(e, t) {
e.exports = {
choose_newsletter: "Выберите рассылки из списка."
};
},
78: function(e, t) {},
87: function(e, t) {
var n = "undefined" != typeof window ? window : "undefined" != typeof WorkerGlobalScope && self instanceof WorkerGlobalScope ? self : {}, r = function() {
var e = /\blang(?:uage)?-(\w+)\b/i, t = 0, r = n.Prism = {
manual: n.Prism && n.Prism.manual,
disableWorkerMessageHandler: n.Prism && n.Prism.disableWorkerMessageHandler,
util: {
encode: function(e) {
return e instanceof a ? new a(e.type, r.util.encode(e.content), e.alias) : "Array" === r.util.type(e) ? e.map(r.util.encode) : e.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/\u00a0/g, " ");
},
type: function(e) {
return Object.prototype.toString.call(e).match(/\[object (\w+)\]/)[1];
},
objId: function(e) {
return e.__id || Object.defineProperty(e, "__id", {
value: ++t
}), e.__id;
},
clone: function(e) {
switch (r.util.type(e)) {
case "Object":
var t = {};
for (var n in e) e.hasOwnProperty(n) && (t[n] = r.util.clone(e[n]));
return t;

case "Array":
return e.map(function(e) {
return r.util.clone(e);
});
}
return e;
}
},
languages: {
extend: function(e, t) {
var n = r.util.clone(r.languages[e]);
for (var a in t) n[a] = t[a];
return n;
},
insertBefore: function(e, t, n, a) {
a = a || r.languages;
var i = a[e];
if (2 == arguments.length) {
n = arguments[1];
for (var s in n) n.hasOwnProperty(s) && (i[s] = n[s]);
return i;
}
var o = {};
for (var l in i) if (i.hasOwnProperty(l)) {
if (l == t) for (var s in n) n.hasOwnProperty(s) && (o[s] = n[s]);
o[l] = i[l];
}
return r.languages.DFS(r.languages, function(t, n) {
n === a[e] && t != e && (this[t] = o);
}), a[e] = o;
},
DFS: function(e, t, n, a) {
a = a || {};
for (var i in e) e.hasOwnProperty(i) && (t.call(e, i, e[i], n || i), "Object" !== r.util.type(e[i]) || a[r.util.objId(e[i])] ? "Array" !== r.util.type(e[i]) || a[r.util.objId(e[i])] || (a[r.util.objId(e[i])] = !0, 
r.languages.DFS(e[i], t, i, a)) : (a[r.util.objId(e[i])] = !0, r.languages.DFS(e[i], t, null, a)));
}
},
plugins: {},
highlightAll: function(e, t) {
var n = {
callback: t,
selector: 'code[class*="language-"], [class*="language-"] code, code[class*="lang-"], [class*="lang-"] code'
};
r.hooks.run("before-highlightall", n);
for (var a, i = n.elements || document.querySelectorAll(n.selector), s = 0; a = i[s++]; ) r.highlightElement(a, !0 === e, n.callback);
},
highlightElement: function(t, a, i) {
for (var s, o, l = t; l && !e.test(l.className); ) l = l.parentNode;
l && (s = (l.className.match(e) || [ , "" ])[1].toLowerCase(), o = r.languages[s]), 
t.className = t.className.replace(e, "").replace(/\s+/g, " ") + " language-" + s, 
t.parentNode && (l = t.parentNode, /pre/i.test(l.nodeName) && (l.className = l.className.replace(e, "").replace(/\s+/g, " ") + " language-" + s));
var c = t.textContent, u = {
element: t,
language: s,
grammar: o,
code: c
};
if (r.hooks.run("before-sanity-check", u), !u.code || !u.grammar) return u.code && (r.hooks.run("before-highlight", u), 
u.element.textContent = u.code, r.hooks.run("after-highlight", u)), void r.hooks.run("complete", u);
if (r.hooks.run("before-highlight", u), a && n.Worker) {
var d = new Worker(r.filename);
d.onmessage = function(e) {
u.highlightedCode = e.data, r.hooks.run("before-insert", u), u.element.innerHTML = u.highlightedCode, 
i && i.call(u.element), r.hooks.run("after-highlight", u), r.hooks.run("complete", u);
}, d.postMessage(JSON.stringify({
language: u.language,
code: u.code,
immediateClose: !0
}));
} else u.highlightedCode = r.highlight(u.code, u.grammar, u.language), r.hooks.run("before-insert", u), 
u.element.innerHTML = u.highlightedCode, i && i.call(t), r.hooks.run("after-highlight", u), 
r.hooks.run("complete", u);
},
highlight: function(e, t, n) {
var i = r.tokenize(e, t);
return a.stringify(r.util.encode(i), n);
},
matchGrammar: function(e, t, n, a, i, s, o) {
var l = r.Token;
for (var c in n) if (n.hasOwnProperty(c) && n[c]) {
if (c == o) return;
var u = n[c];
u = "Array" === r.util.type(u) ? u : [ u ];
for (var d = 0; d < u.length; ++d) {
var p = u[d], m = p.inside, h = !!p.lookbehind, f = !!p.greedy, g = 0, b = p.alias;
if (f && !p.pattern.global) {
var E = ("" + p.pattern).match(/[imuy]*$/)[0];
p.pattern = RegExp(p.pattern.source, E + "g");
}
p = p.pattern || p;
for (var y = a, v = i; y < t.length; v += t[y].length, ++y) {
var w = t[y];
if (t.length > e.length) return;
if (!(w instanceof l)) {
p.lastIndex = 0;
var S = p.exec(w), T = 1;
if (!S && f && y != t.length - 1) {
if (p.lastIndex = v, !(S = p.exec(e))) break;
for (var k = S.index + (h ? S[1].length : 0), _ = S.index + S[0].length, A = y, C = v, L = t.length; A < L && (C < _ || !t[A].type && !t[A - 1].greedy); ++A) C += t[A].length, 
k >= C && (++y, v = C);
if (t[y] instanceof l || t[A - 1].greedy) continue;
T = A - y, w = e.slice(v, C), S.index -= v;
}
if (S) {
h && (g = S[1].length);
var k = S.index + g, S = S[0].slice(g), _ = k + S.length, I = w.slice(0, k), N = w.slice(_), O = [ y, T ];
I && (++y, v += I.length, O.push(I));
var R = new l(c, m ? r.tokenize(S, m) : S, b, S, f);
if (O.push(R), N && O.push(N), Array.prototype.splice.apply(t, O), 1 != T && r.matchGrammar(e, t, n, y, v, !0, c), 
s) break;
} else if (s) break;
}
}
}
}
},
tokenize: function(e, t, n) {
var a = [ e ], i = t.rest;
if (i) {
for (var s in i) t[s] = i[s];
delete t.rest;
}
return r.matchGrammar(e, a, t, 0, 0, !1), a;
},
hooks: {
all: {},
add: function(e, t) {
var n = r.hooks.all;
n[e] = n[e] || [], n[e].push(t);
},
run: function(e, t) {
var n = r.hooks.all[e];
if (n && n.length) for (var a, i = 0; a = n[i++]; ) a(t);
}
}
}, a = r.Token = function(e, t, n, r, a) {
this.type = e, this.content = t, this.alias = n, this.length = 0 | (r || "").length, 
this.greedy = !!a;
};
if (a.stringify = function(e, t, n) {
if ("string" == typeof e) return e;
if ("Array" === r.util.type(e)) return e.map(function(n) {
return a.stringify(n, t, e);
}).join("");
var i = {
type: e.type,
content: a.stringify(e.content, t, n),
tag: "span",
classes: [ "token", e.type ],
attributes: {},
language: t,
parent: n
};
if (e.alias) {
var s = "Array" === r.util.type(e.alias) ? e.alias : [ e.alias ];
Array.prototype.push.apply(i.classes, s);
}
r.hooks.run("wrap", i);
var o = Object.keys(i.attributes).map(function(e) {
return e + '="' + (i.attributes[e] || "").replace(/"/g, "&quot;") + '"';
}).join(" ");
return "<" + i.tag + ' class="' + i.classes.join(" ") + '"' + (o ? " " + o : "") + ">" + i.content + "</" + i.tag + ">";
}, !n.document) return n.addEventListener ? (r.disableWorkerMessageHandler || n.addEventListener("message", function(e) {
var t = JSON.parse(e.data), a = t.language, i = t.code, s = t.immediateClose;
n.postMessage(r.highlight(i, r.languages[a], a)), s && n.close();
}, !1), n.Prism) : n.Prism;
var i = document.currentScript || [].slice.call(document.getElementsByTagName("script")).pop();
return i && (r.filename = i.src, r.manual || i.hasAttribute("data-manual") || ("loading" !== document.readyState ? window.requestAnimationFrame ? window.requestAnimationFrame(r.highlightAll) : window.setTimeout(r.highlightAll, 16) : document.addEventListener("DOMContentLoaded", r.highlightAll))), 
n.Prism;
}();
void 0 !== e && e.exports && (e.exports = r), "undefined" != typeof global && (global.Prism = r);
},
88: function(e, t) {
Prism.languages.markup = {
comment: /<!--[\s\S]*?-->/,
prolog: /<\?[\s\S]+?\?>/,
doctype: /<!DOCTYPE[\s\S]+?>/i,
cdata: /<!\[CDATA\[[\s\S]*?]]>/i,
tag: {
pattern: /<\/?(?!\d)[^\s>\/=$<]+(?:\s+[^\s>\/=]+(?:=(?:("|')(?:\\[\s\S]|(?!\1)[^\\])*\1|[^\s'">=]+))?)*\s*\/?>/i,
inside: {
tag: {
pattern: /^<\/?[^\s>\/]+/i,
inside: {
punctuation: /^<\/?/,
namespace: /^[^\s>\/:]+:/
}
},
"attr-value": {
pattern: /=(?:("|')(?:\\[\s\S]|(?!\1)[^\\])*\1|[^\s'">=]+)/i,
inside: {
punctuation: [ /^=/, {
pattern: /(^|[^\\])["']/,
lookbehind: !0
} ]
}
},
punctuation: /\/?>/,
"attr-name": {
pattern: /[^\s>\/]+/,
inside: {
namespace: /^[^\s>\/:]+:/
}
}
}
},
entity: /&#?[\da-z]{1,8};/i
}, Prism.languages.markup.tag.inside["attr-value"].inside.entity = Prism.languages.markup.entity, 
Prism.hooks.add("wrap", function(e) {
"entity" === e.type && (e.attributes.title = e.content.replace(/&amp;/, "&"));
}), Prism.languages.xml = Prism.languages.markup, Prism.languages.html = Prism.languages.markup, 
Prism.languages.mathml = Prism.languages.markup, Prism.languages.svg = Prism.languages.markup;
},
89: function(e, t) {
Prism.languages.css = {
comment: /\/\*[\s\S]*?\*\//,
atrule: {
pattern: /@[\w-]+?.*?(?:;|(?=\s*\{))/i,
inside: {
rule: /@[\w-]+/
}
},
url: /url\((?:(["'])(?:\\(?:\r\n|[\s\S])|(?!\1)[^\\\r\n])*\1|.*?)\)/i,
selector: /[^{}\s][^{};]*?(?=\s*\{)/,
string: {
pattern: /("|')(?:\\(?:\r\n|[\s\S])|(?!\1)[^\\\r\n])*\1/,
greedy: !0
},
property: /[\w-]+(?=\s*:)/i,
important: /\B!important\b/i,
function: /[-a-z0-9]+(?=\()/i,
punctuation: /[(){};:]/
}, Prism.languages.css.atrule.inside.rest = Prism.util.clone(Prism.languages.css), 
Prism.languages.markup && (Prism.languages.insertBefore("markup", "tag", {
style: {
pattern: /(<style[\s\S]*?>)[\s\S]*?(?=<\/style>)/i,
lookbehind: !0,
inside: Prism.languages.css,
alias: "language-css"
}
}), Prism.languages.insertBefore("inside", "attr-value", {
"style-attr": {
pattern: /\s*style=("|')(?:\\[\s\S]|(?!\1)[^\\])*\1/i,
inside: {
"attr-name": {
pattern: /^\s*style/i,
inside: Prism.languages.markup.tag.inside
},
punctuation: /^\s*=\s*['"]|['"]\s*$/,
"attr-value": {
pattern: /.+/i,
inside: Prism.languages.css
}
},
alias: "language-css"
}
}, Prism.languages.markup.tag));
},
90: function(e, t) {
Prism.languages.css.selector = {
pattern: /[^{}\s][^{}]*(?=\s*\{)/,
inside: {
"pseudo-element": /:(?:after|before|first-letter|first-line|selection)|::[-\w]+/,
"pseudo-class": /:[-\w]+(?:\(.*\))?/,
class: /\.[-:.\w]+/,
id: /#[-:.\w]+/,
attribute: /\[[^\]]+\]/
}
}, Prism.languages.insertBefore("css", "function", {
hexcode: /#[\da-f]{3,8}/i,
entity: /\\[\da-f]{1,8}/i,
number: /[\d%.]+/
});
},
91: function(e, t) {
Prism.languages.clike = {
comment: [ {
pattern: /(^|[^\\])\/\*[\s\S]*?(?:\*\/|$)/,
lookbehind: !0
}, {
pattern: /(^|[^\\:])\/\/.*/,
lookbehind: !0
} ],
string: {
pattern: /(["'])(?:\\(?:\r\n|[\s\S])|(?!\1)[^\\\r\n])*\1/,
greedy: !0
},
"class-name": {
pattern: /((?:\b(?:class|interface|extends|implements|trait|instanceof|new)\s+)|(?:catch\s+\())[\w.\\]+/i,
lookbehind: !0,
inside: {
punctuation: /[.\\]/
}
},
keyword: /\b(?:if|else|while|do|for|return|in|instanceof|function|new|try|throw|catch|finally|null|break|continue)\b/,
boolean: /\b(?:true|false)\b/,
function: /[a-z0-9_]+(?=\()/i,
number: /\b-?(?:0x[\da-f]+|\d*\.?\d+(?:e[+-]?\d+)?)\b/i,
operator: /--?|\+\+?|!=?=?|<=?|>=?|==?=?|&&?|\|\|?|\?|\*|\/|~|\^|%/,
punctuation: /[{}[\];(),.:]/
};
},
92: function(e, t) {
Prism.languages.javascript = Prism.languages.extend("clike", {
keyword: /\b(?:as|async|await|break|case|catch|class|const|continue|debugger|default|delete|do|else|enum|export|extends|finally|for|from|function|get|if|implements|import|in|instanceof|interface|let|new|null|of|package|private|protected|public|return|set|static|super|switch|this|throw|try|typeof|var|void|while|with|yield)\b/,
number: /\b-?(?:0[xX][\dA-Fa-f]+|0[bB][01]+|0[oO][0-7]+|\d*\.?\d+(?:[Ee][+-]?\d+)?|NaN|Infinity)\b/,
function: /[_$a-zA-Z\xA0-\uFFFF][_$a-zA-Z0-9\xA0-\uFFFF]*(?=\s*\()/i,
operator: /-[-=]?|\+[+=]?|!=?=?|<<?=?|>>?>?=?|=(?:==?|>)?|&[&=]?|\|[|=]?|\*\*?=?|\/=?|~|\^=?|%=?|\?|\.{3}/
}), Prism.languages.insertBefore("javascript", "keyword", {
regex: {
pattern: /(^|[^\/])\/(?!\/)(\[[^\]\r\n]+]|\\.|[^\/\\\[\r\n])+\/[gimyu]{0,5}(?=\s*($|[\r\n,.;})]))/,
lookbehind: !0,
greedy: !0
},
"function-variable": {
pattern: /[_$a-zA-Z\xA0-\uFFFF][_$a-zA-Z0-9\xA0-\uFFFF]*(?=\s*=\s*(?:function\b|(?:\([^()]*\)|[_$a-zA-Z\xA0-\uFFFF][_$a-zA-Z0-9\xA0-\uFFFF]*)\s*=>))/i,
alias: "function"
}
}), Prism.languages.insertBefore("javascript", "string", {
"template-string": {
pattern: /`(?:\\[\s\S]|[^\\`])*`/,
greedy: !0,
inside: {
interpolation: {
pattern: /\$\{[^}]+\}/,
inside: {
"interpolation-punctuation": {
pattern: /^\$\{|\}$/,
alias: "punctuation"
},
rest: Prism.languages.javascript
}
},
string: /[\s\S]+/
}
}
}), Prism.languages.markup && Prism.languages.insertBefore("markup", "tag", {
script: {
pattern: /(<script[\s\S]*?>)[\s\S]*?(?=<\/script>)/i,
lookbehind: !0,
inside: Prism.languages.javascript,
alias: "language-javascript"
}
}), Prism.languages.js = Prism.languages.javascript;
},
93: function(e, t) {
!function(e) {
var t = /#(?!\{).+/, n = {
pattern: /#\{[^}]+\}/,
alias: "variable"
};
e.languages.coffeescript = e.languages.extend("javascript", {
comment: t,
string: [ {
pattern: /'(?:\\[\s\S]|[^\\'])*'/,
greedy: !0
}, {
pattern: /"(?:\\[\s\S]|[^\\"])*"/,
greedy: !0,
inside: {
interpolation: n
}
} ],
keyword: /\b(?:and|break|by|catch|class|continue|debugger|delete|do|each|else|extend|extends|false|finally|for|if|in|instanceof|is|isnt|let|loop|namespace|new|no|not|null|of|off|on|or|own|return|super|switch|then|this|throw|true|try|typeof|undefined|unless|until|when|while|window|with|yes|yield)\b/,
"class-member": {
pattern: /@(?!\d)\w+/,
alias: "variable"
}
}), e.languages.insertBefore("coffeescript", "comment", {
"multiline-comment": {
pattern: /###[\s\S]+?###/,
alias: "comment"
},
"block-regex": {
pattern: /\/{3}[\s\S]*?\/{3}/,
alias: "regex",
inside: {
comment: t,
interpolation: n
}
}
}), e.languages.insertBefore("coffeescript", "string", {
"inline-javascript": {
pattern: /`(?:\\[\s\S]|[^\\`])*`/,
inside: {
delimiter: {
pattern: /^`|`$/,
alias: "punctuation"
},
rest: e.languages.javascript
}
},
"multiline-string": [ {
pattern: /'''[\s\S]*?'''/,
greedy: !0,
alias: "string"
}, {
pattern: /"""[\s\S]*?"""/,
greedy: !0,
alias: "string",
inside: {
interpolation: n
}
} ]
}), e.languages.insertBefore("coffeescript", "keyword", {
property: /(?!\d)\w+(?=\s*:(?!:))/
}), delete e.languages.coffeescript["template-string"];
}(Prism);
},
94: function(e, t) {
Prism.languages.http = {
"request-line": {
pattern: /^(?:POST|GET|PUT|DELETE|OPTIONS|PATCH|TRACE|CONNECT)\shttps?:\/\/\S+\sHTTP\/[0-9.]+/m,
inside: {
property: /^(?:POST|GET|PUT|DELETE|OPTIONS|PATCH|TRACE|CONNECT)\b/,
"attr-name": /:\w+/
}
},
"response-status": {
pattern: /^HTTP\/1.[01] \d+.*/m,
inside: {
property: {
pattern: /(^HTTP\/1.[01] )\d+.*/i,
lookbehind: !0
}
}
},
"header-name": {
pattern: /^[\w-]+:(?=.)/m,
alias: "keyword"
}
};
var n = {
"application/json": Prism.languages.javascript,
"application/xml": Prism.languages.markup,
"text/xml": Prism.languages.markup,
"text/html": Prism.languages.markup
};
for (var r in n) if (n[r]) {
var a = {};
a[r] = {
pattern: RegExp("(content-type:\\s*" + r + "[\\w\\W]*?)(?:\\r?\\n|\\r){2}[\\w\\W]*", "i"),
lookbehind: !0,
inside: {
rest: n[r]
}
}, Prism.languages.insertBefore("http", "header-name", a);
}
},
95: function(e, t) {
Prism.languages.scss = Prism.languages.extend("css", {
comment: {
pattern: /(^|[^\\])(?:\/\*[\s\S]*?\*\/|\/\/.*)/,
lookbehind: !0
},
atrule: {
pattern: /@[\w-]+(?:\([^()]+\)|[^(])*?(?=\s+[{;])/,
inside: {
rule: /@[\w-]+/
}
},
url: /(?:[-a-z]+-)*url(?=\()/i,
selector: {
pattern: /(?=\S)[^@;{}()]?(?:[^@;{}()]|&|#\{\$[-\w]+\})+(?=\s*\{(?:\}|\s|[^}]+[:{][^}]+))/m,
inside: {
parent: {
pattern: /&/,
alias: "important"
},
placeholder: /%[-\w]+/,
variable: /\$[-\w]+|#\{\$[-\w]+\}/
}
}
}), Prism.languages.insertBefore("scss", "atrule", {
keyword: [ /@(?:if|else(?: if)?|for|each|while|import|extend|debug|warn|mixin|include|function|return|content)/i, {
pattern: /( +)(?:from|through)(?= )/,
lookbehind: !0
} ]
}), Prism.languages.scss.property = {
pattern: /(?:[\w-]|\$[-\w]+|#\{\$[-\w]+\})+(?=\s*:)/i,
inside: {
variable: /\$[-\w]+|#\{\$[-\w]+\}/
}
}, Prism.languages.insertBefore("scss", "important", {
variable: /\$[-\w]+|#\{\$[-\w]+\}/
}), Prism.languages.insertBefore("scss", "function", {
placeholder: {
pattern: /%[-\w]+/,
alias: "selector"
},
statement: {
pattern: /\B!(?:default|optional)\b/i,
alias: "keyword"
},
boolean: /\b(?:true|false)\b/,
null: /\bnull\b/,
operator: {
pattern: /(\s)(?:[-+*\/%]|[=!]=|<=?|>=?|and|or|not)(?=\s)/,
lookbehind: !0
}
}), Prism.languages.scss.atrule.inside.rest = Prism.util.clone(Prism.languages.scss);
},
96: function(e, t) {
Prism.languages.sql = {
comment: {
pattern: /(^|[^\\])(?:\/\*[\s\S]*?\*\/|(?:--|\/\/|#).*)/,
lookbehind: !0
},
string: {
pattern: /(^|[^@\\])("|')(?:\\[\s\S]|(?!\2)[^\\])*\2/,
greedy: !0,
lookbehind: !0
},
variable: /@[\w.$]+|@(["'`])(?:\\[\s\S]|(?!\1)[^\\])+\1/,
function: /\b(?:COUNT|SUM|AVG|MIN|MAX|FIRST|LAST|UCASE|LCASE|MID|LEN|ROUND|NOW|FORMAT)(?=\s*\()/i,
keyword: /\b(?:ACTION|ADD|AFTER|ALGORITHM|ALL|ALTER|ANALYZE|ANY|APPLY|AS|ASC|AUTHORIZATION|AUTO_INCREMENT|BACKUP|BDB|BEGIN|BERKELEYDB|BIGINT|BINARY|BIT|BLOB|BOOL|BOOLEAN|BREAK|BROWSE|BTREE|BULK|BY|CALL|CASCADED?|CASE|CHAIN|CHAR VARYING|CHARACTER (?:SET|VARYING)|CHARSET|CHECK|CHECKPOINT|CLOSE|CLUSTERED|COALESCE|COLLATE|COLUMN|COLUMNS|COMMENT|COMMIT|COMMITTED|COMPUTE|CONNECT|CONSISTENT|CONSTRAINT|CONTAINS|CONTAINSTABLE|CONTINUE|CONVERT|CREATE|CROSS|CURRENT(?:_DATE|_TIME|_TIMESTAMP|_USER)?|CURSOR|DATA(?:BASES?)?|DATE(?:TIME)?|DBCC|DEALLOCATE|DEC|DECIMAL|DECLARE|DEFAULT|DEFINER|DELAYED|DELETE|DELIMITER(?:S)?|DENY|DESC|DESCRIBE|DETERMINISTIC|DISABLE|DISCARD|DISK|DISTINCT|DISTINCTROW|DISTRIBUTED|DO|DOUBLE(?: PRECISION)?|DROP|DUMMY|DUMP(?:FILE)?|DUPLICATE KEY|ELSE|ENABLE|ENCLOSED BY|END|ENGINE|ENUM|ERRLVL|ERRORS|ESCAPE(?:D BY)?|EXCEPT|EXEC(?:UTE)?|EXISTS|EXIT|EXPLAIN|EXTENDED|FETCH|FIELDS|FILE|FILLFACTOR|FIRST|FIXED|FLOAT|FOLLOWING|FOR(?: EACH ROW)?|FORCE|FOREIGN|FREETEXT(?:TABLE)?|FROM|FULL|FUNCTION|GEOMETRY(?:COLLECTION)?|GLOBAL|GOTO|GRANT|GROUP|HANDLER|HASH|HAVING|HOLDLOCK|IDENTITY(?:_INSERT|COL)?|IF|IGNORE|IMPORT|INDEX|INFILE|INNER|INNODB|INOUT|INSERT|INT|INTEGER|INTERSECT|INTO|INVOKER|ISOLATION LEVEL|JOIN|KEYS?|KILL|LANGUAGE SQL|LAST|LEFT|LIMIT|LINENO|LINES|LINESTRING|LOAD|LOCAL|LOCK|LONG(?:BLOB|TEXT)|MATCH(?:ED)?|MEDIUM(?:BLOB|INT|TEXT)|MERGE|MIDDLEINT|MODIFIES SQL DATA|MODIFY|MULTI(?:LINESTRING|POINT|POLYGON)|NATIONAL(?: CHAR VARYING| CHARACTER(?: VARYING)?| VARCHAR)?|NATURAL|NCHAR(?: VARCHAR)?|NEXT|NO(?: SQL|CHECK|CYCLE)?|NONCLUSTERED|NULLIF|NUMERIC|OFF?|OFFSETS?|ON|OPEN(?:DATASOURCE|QUERY|ROWSET)?|OPTIMIZE|OPTION(?:ALLY)?|ORDER|OUT(?:ER|FILE)?|OVER|PARTIAL|PARTITION|PERCENT|PIVOT|PLAN|POINT|POLYGON|PRECEDING|PRECISION|PREV|PRIMARY|PRINT|PRIVILEGES|PROC(?:EDURE)?|PUBLIC|PURGE|QUICK|RAISERROR|READ(?:S SQL DATA|TEXT)?|REAL|RECONFIGURE|REFERENCES|RELEASE|RENAME|REPEATABLE|REPLICATION|REQUIRE|RESTORE|RESTRICT|RETURNS?|REVOKE|RIGHT|ROLLBACK|ROUTINE|ROW(?:COUNT|GUIDCOL|S)?|RTREE|RULE|SAVE(?:POINT)?|SCHEMA|SELECT|SERIAL(?:IZABLE)?|SESSION(?:_USER)?|SET(?:USER)?|SHARE MODE|SHOW|SHUTDOWN|SIMPLE|SMALLINT|SNAPSHOT|SOME|SONAME|START(?:ING BY)?|STATISTICS|STATUS|STRIPED|SYSTEM_USER|TABLES?|TABLESPACE|TEMP(?:ORARY|TABLE)?|TERMINATED BY|TEXT(?:SIZE)?|THEN|TIMESTAMP|TINY(?:BLOB|INT|TEXT)|TOP?|TRAN(?:SACTIONS?)?|TRIGGER|TRUNCATE|TSEQUAL|TYPES?|UNBOUNDED|UNCOMMITTED|UNDEFINED|UNION|UNIQUE|UNPIVOT|UPDATE(?:TEXT)?|USAGE|USE|USER|USING|VALUES?|VAR(?:BINARY|CHAR|CHARACTER|YING)|VIEW|WAITFOR|WARNINGS|WHEN|WHERE|WHILE|WITH(?: ROLLUP|IN)?|WORK|WRITE(?:TEXT)?)\b/i,
boolean: /\b(?:TRUE|FALSE|NULL)\b/i,
number: /\b-?(?:0x)?\d*\.?[\da-f]+\b/,
operator: /[-+*\/=%^~]|&&?|\|\|?|!=?|<(?:=>?|<|>)?|>[>=]?|\b(?:AND|BETWEEN|IN|LIKE|NOT|OR|IS|DIV|REGEXP|RLIKE|SOUNDS LIKE|XOR)\b/i,
punctuation: /[;[\]()`,.]/
};
},
97: function(e, t) {
Prism.languages.php = Prism.languages.extend("clike", {
keyword: /\b(?:and|or|xor|array|as|break|case|cfunction|class|const|continue|declare|default|die|do|else|elseif|enddeclare|endfor|endforeach|endif|endswitch|endwhile|extends|for|foreach|function|include|include_once|global|if|new|return|static|switch|use|require|require_once|var|while|abstract|interface|public|implements|private|protected|parent|throw|null|echo|print|trait|namespace|final|yield|goto|instanceof|finally|try|catch)\b/i,
constant: /\b[A-Z0-9_]{2,}\b/,
comment: {
pattern: /(^|[^\\])(?:\/\*[\s\S]*?\*\/|\/\/.*)/,
lookbehind: !0
}
}), Prism.languages.insertBefore("php", "class-name", {
"shell-comment": {
pattern: /(^|[^\\])#.*/,
lookbehind: !0,
alias: "comment"
}
}), Prism.languages.insertBefore("php", "keyword", {
delimiter: {
pattern: /\?>|<\?(?:php|=)?/i,
alias: "important"
},
variable: /\$\w+\b/i,
package: {
pattern: /(\\|namespace\s+|use\s+)[\w\\]+/,
lookbehind: !0,
inside: {
punctuation: /\\/
}
}
}), Prism.languages.insertBefore("php", "operator", {
property: {
pattern: /(->)[\w]+/,
lookbehind: !0
}
}), Prism.languages.markup && (Prism.hooks.add("before-highlight", function(e) {
"php" === e.language && /(?:<\?php|<\?)/gi.test(e.code) && (e.tokenStack = [], e.backupCode = e.code, 
e.code = e.code.replace(/(?:<\?php|<\?)[\s\S]*?(?:\?>|$)/gi, function(t) {
for (var n = e.tokenStack.length; -1 !== e.backupCode.indexOf("___PHP" + n + "___"); ) ++n;
return e.tokenStack[n] = t, "___PHP" + n + "___";
}), e.grammar = Prism.languages.markup);
}), Prism.hooks.add("before-insert", function(e) {
"php" === e.language && e.backupCode && (e.code = e.backupCode, delete e.backupCode);
}), Prism.hooks.add("after-highlight", function(e) {
if ("php" === e.language && e.tokenStack) {
e.grammar = Prism.languages.php;
for (var t = 0, n = Object.keys(e.tokenStack); t < n.length; ++t) {
var r = n[t], a = e.tokenStack[r];
e.highlightedCode = e.highlightedCode.replace("___PHP" + r + "___", '<span class="token php language-php">' + Prism.highlight(a, e.grammar, "php").replace(/\$/g, "$$$$") + "</span>");
}
e.element.innerHTML = e.highlightedCode;
}
}));
},
98: function(e, t) {
Prism.languages.insertBefore("php", "variable", {
this: /\$this\b/,
global: /\$(?:_(?:SERVER|GET|POST|FILES|REQUEST|SESSION|ENV|COOKIE)|GLOBALS|HTTP_RAW_POST_DATA|argc|argv|php_errormsg|http_response_header)\b/,
scope: {
pattern: /\b[\w\\]+::/,
inside: {
keyword: /static|self|parent/,
punctuation: /::|\\/
}
}
});
},
99: function(e, t) {
Prism.languages.python = {
comment: {
pattern: /(^|[^\\])#.*/,
lookbehind: !0
},
"triple-quoted-string": {
pattern: /("""|''')[\s\S]+?\1/,
greedy: !0,
alias: "string"
},
string: {
pattern: /("|')(?:\\.|(?!\1)[^\\\r\n])*\1/,
greedy: !0
},
function: {
pattern: /((?:^|\s)def[ \t]+)[a-zA-Z_]\w*(?=\s*\()/g,
lookbehind: !0
},
"class-name": {
pattern: /(\bclass\s+)\w+/i,
lookbehind: !0
},
keyword: /\b(?:as|assert|async|await|break|class|continue|def|del|elif|else|except|exec|finally|for|from|global|if|import|in|is|lambda|nonlocal|pass|print|raise|return|try|while|with|yield)\b/,
builtin: /\b(?:__import__|abs|all|any|apply|ascii|basestring|bin|bool|buffer|bytearray|bytes|callable|chr|classmethod|cmp|coerce|compile|complex|delattr|dict|dir|divmod|enumerate|eval|execfile|file|filter|float|format|frozenset|getattr|globals|hasattr|hash|help|hex|id|input|int|intern|isinstance|issubclass|iter|len|list|locals|long|map|max|memoryview|min|next|object|oct|open|ord|pow|property|range|raw_input|reduce|reload|repr|reversed|round|set|setattr|slice|sorted|staticmethod|str|sum|super|tuple|type|unichr|unicode|vars|xrange|zip)\b/,
boolean: /\b(?:True|False|None)\b/,
number: /\b-?(?:0[bo])?(?:(?:\d|0x[\da-f])[\da-f]*\.?\d*|\.\d+)(?:e[+-]?\d+)?j?\b/i,
operator: /[-+%=]=?|!=|\*\*?=?|\/\/?=?|<[<=>]?|>[=>]?|[&|^~]|\b(?:or|and|not)\b/,
punctuation: /[{}[\];(),.:]/
};
}
}, [ 18 ]);