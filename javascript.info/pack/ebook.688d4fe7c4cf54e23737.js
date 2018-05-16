var ebook = webpackJsonp_name_([ 8 ], {
23: function(e, t, r) {
"use strict";
var n = r(558);
!function() {
var e = document.querySelector("[data-order-form]");
e && new n({
elem: e
});
}();
},
24: function(e, t, r) {
function n(e) {
return r(o(e));
}
function o(e) {
var t = a[e];
if (!(t + 1)) throw Error("Cannot find module '" + e + "'.");
return t;
}
var a = {
"./en.yml": 678,
"./ru.yml": 679
};
n.keys = function() {
return Object.keys(a);
}, n.resolve = o, e.exports = n, n.id = 24;
},
5: function(e, t, r) {
function n(e) {
return r(o(e));
}
function o(e) {
var t = a[e];
if (!(t + 1)) throw Error("Cannot find module '" + e + "'.");
return t;
}
var a = {
"./en.yml": 675,
"./ru.yml": 676
};
n.keys = function() {
return Object.keys(a);
}, n.resolve = o, e.exports = n, n.id = 5;
},
531: function(e, t, r) {
"use strict";
function n(e) {
function t(e, t) {
var r = new CustomEvent(e);
return r.originalEvent = t, r;
}
function r(e, r) {
var n = t("fail", r);
n.reason = e, o.dispatchEvent(n);
}
function n(e, r) {
var n = t("success", r);
n.result = e, o.dispatchEvent(n);
}
var o = new XMLHttpRequest(), i = e.method || "GET", c = e.body, u = e.url;
o.open(i, u, !e.sync), o.method = i;
var l = a();
l && !e.skipCsrf && o.setRequestHeader("X-XSRF-TOKEN", l), "[object Object]" == {}.toString.call(c) && (o.setRequestHeader("Content-Type", "application/json;charset=UTF-8"), 
c = JSON.stringify(c)), e.noDocumentEvents || (o.addEventListener("loadstart", function(e) {
o.timeStart = Date.now();
var r = t("xhrstart", e);
document.dispatchEvent(r);
}), o.addEventListener("loadend", function(e) {
var r = t("xhrend", e);
document.dispatchEvent(r);
}), o.addEventListener("success", function(e) {
var r = t("xhrsuccess", e);
r.result = e.result, document.dispatchEvent(r);
}), o.addEventListener("fail", function(e) {
var r = t("xhrfail", e);
r.reason = e.reason, document.dispatchEvent(r);
})), e.raw || o.setRequestHeader("Accept", "application/json"), o.setRequestHeader("X-Requested-With", "XMLHttpRequest");
var m = e.normalStatuses || [ 200 ];
return o.addEventListener("error", function(e) {
r(s("site.errors.server_connection_error"), e);
}), o.addEventListener("timeout", function(e) {
r(s("site.errors.server_request_timeout"), e);
}), o.addEventListener("abort", function(e) {
r(s("site.errors.request_aborted"), e);
}), o.addEventListener("load", function(t) {
if (!o.status) return void r(s("site.errors.no_response"), t);
if (-1 == m.indexOf(o.status)) return void r(s("site.errors.server_error", {
status: response.status
}), t);
var a = o.responseText;
if (o.getResponseHeader("Content-Type").match(/^application\/json/) || e.json) try {
a = JSON.parse(a);
} catch (t) {
return void r(s("site.errors.invalid_format"), t);
}
n(a, t);
}), setTimeout(function() {
o.send(c);
}, 0), o;
}
var o = r(523), a = r(532), i = r(537).lang, s = r(538);
s.requirePhrase("site", r(1)("./" + i + ".yml")), document.addEventListener("xhrfail", function(e) {
new o.Error(e.reason);
}), e.exports = n;
},
532: function(e, t, r) {
"use strict";
e.exports = function() {
var e = document.cookie.match(/XSRF-TOKEN=([\w-]+)/);
return e ? e[1] : null;
};
},
553: function(e, t, r) {
"use strict";
t.FormPayment = r(554);
},
554: function(e, t, r) {
"use strict";
function n(e, t) {
if (!(e instanceof t)) throw new TypeError("Cannot call a class as a function");
}
var o = function() {
function e(e, t) {
for (var r = 0; r < t.length; r++) {
var n = t[r];
n.enumerable = n.enumerable || !1, n.configurable = !0, "value" in n && (n.writable = !0), 
Object.defineProperty(e, n.key, n);
}
}
return function(t, r, n) {
return r && e(t.prototype, r), n && e(t, n), t;
};
}(), a = r(523), i = r(531), s = r(526), c = (r(529), r(538)), u = r(537);
c.requirePhrase("payments", r(5)("./" + u.lang + ".yml"));
var l = function() {
function e(t, r) {
n(this, e), this.orderForm = t, this.paymentMethodElem = r;
}
return o(e, [ {
key: "request",
value: function(e) {
var t = i(e);
return t.addEventListener("loadstart", function() {
var e = this.startRequestIndication();
t.addEventListener("loadend", e);
}.bind(this)), t;
}
}, {
key: "startRequestIndication",
value: function() {
var e = this;
this.paymentMethodElem.classList.add("modal-overlay_light");
var t = new s({
elem: this.paymentMethodElem.querySelector('[type="submit"]'),
size: "small",
class: "",
elemClass: "button_loading"
});
return t.start(), function() {
e.paymentMethodElem.classList.remove("modal-overlay_light"), t && t.stop();
};
}
}, {
key: "readPaymentData",
value: function() {
var e = {};
return [].forEach.call(this.paymentMethodElem.querySelectorAll("input,select,textarea"), function(t) {
("radio" != t.type && "checkbox" != t.type || t.checked) && (e[t.name] = t.value);
}), e;
}
}, {
key: "submit",
value: function() {
var e = this, t = this.orderForm.getOrderData();
if (t) {
var r = this.readPaymentData();
if (!r.paymentMethod) return void new a.Error(c("payments.client.choose_payment_method"));
if ("invoice" == r.paymentMethod && !r.invoiceCompanyName) return new a.Error(c("payments.client.specify_company_name")), 
void this.paymentMethodElem.querySelector('[name="invoiceCompanyName"]').focus();
for (var n in r) t[n] = r[n];
var o = window.location.search.match(/[?&]code=([-\w]+)/);
o && (t.discountCode = o[1]);
var s = i({
method: "POST",
url: "/payments/common/checkout",
normalStatuses: [ 200, 403, 400 ],
body: t
});
t.orderTemplate && window.ga("ec:addProduct", {
id: this.orderForm.product,
variant: t.orderTemplate,
price: t.amount,
quantity: 1
}), window.ga("ec:setAction", "checkout", {
step: 1,
option: t.paymentMethod
}), window.metrika.reachGoal("CHECKOUT", {
product: this.orderForm.product,
method: t.paymentMethod,
price: t.amount
}), window.ga("send", "event", "payment", "checkout", "ebook"), window.ga("send", "event", "payment", "checkout-method-" + t.paymentMethod, this.orderForm.product);
var l = this.startRequestIndication();
s.addEventListener("success", function(r) {
if (403 == s.status) return new a.Error(c("payments.client.error_start_again", {
message: r.result.description || r.result.message || "",
email: u.ordersMail
})), void l();
if (400 == s.status) return new a.Error(c("payments.client.maybe_purchase_error", {
message: r.result.message || r.result.description || "",
email: u.ordersMail
})), void l();
var n = r.result;
if (n.form) {
window.ga("ec:setAction", "purchase", {
id: n.orderNumber
});
var o = document.createElement("div");
o.hidden = !0, o.innerHTML = n.form, document.body.appendChild(o);
var i = function e() {
e.called || (e.called = !0, o.firstChild.submit());
};
window.ga("send", "event", "payment", "purchase", "ebook", {
hitCallback: i
}), setTimeout(i, 500), window.metrika.reachGoal("PURCHASE", {
product: e.orderForm.product,
method: t.paymentMethod,
price: t.amount,
number: n.orderNumber
});
} else l(), new a.Error(c("payments.client.purchase_error", {
email: u.ordersMail
}));
}), s.addEventListener("fail", l);
}
}
} ]), e;
}();
e.exports = l;
},
558: function(e, t, r) {
"use strict";
function n(e, t) {
if (!(e instanceof t)) throw new TypeError("Cannot call a class as a function");
}
var o = function() {
function e(e, t) {
for (var r = 0; r < t.length; r++) {
var n = t[r];
n.enumerable = n.enumerable || !1, n.configurable = !0, "value" in n && (n.writable = !0), 
Object.defineProperty(e, n.key, n);
}
}
return function(t, r, n) {
return r && e(t.prototype, r), n && e(t, n), t;
};
}(), a = (r(531), r(523)), i = r(524), s = r(553).FormPayment, c = (r(526), r(529), 
r(538)), u = r(537).lang;
c.requirePhrase("ebook", r(24)("./" + u + ".yml"));
var l = function() {
function e(t) {
var r = this;
n(this, e), this.elem = t.elem, this.product = "ebook", this.elem.addEventListener("submit", function(e) {
return r.onSubmit(e);
}), this.delegate("[data-order-payment-change]", "click", function(e) {
e.preventDefault(), this.elem.querySelector("[data-order-form-step-payment]").style.display = "block", 
this.elem.querySelector("[data-order-form-step-confirm]").style.display = "none", 
this.elem.querySelector("[data-order-form-step-receipt]").style.display = "none";
}), this.delegate(".complex-form__extract .extract__item", "click", function(e) {
e.delegateTarget.querySelector('[type="radio"]').checked = !0;
});
}
return o(e, [ {
key: "onSubmit",
value: function(e) {
e.preventDefault(), new s(this, this.elem).submit();
}
}, {
key: "getOrderData",
value: function() {
var e = {};
if (window.orderNumber) e.orderNumber = window.orderNumber; else {
var t = this.elem.querySelector('input[name="orderTemplate"]:checked');
e.orderTemplate = t.value, e.amount = t.dataset.amount;
}
if (this.elem.elements.email) {
if (!this.elem.elements.email.value) return window.ga("send", "event", "payment", "checkout-no-email", "ebook"), 
window.metrika.reachGoal("CHECKOUT-NO-EMAIL", {
product: "ebook"
}), new a.Error(c("ebook.client.enter_email")), this.elem.elements.email.scrollIntoView(), 
setTimeout(function() {
window.scrollBy(0, -200);
}, 0), void this.elem.elements.email.focus();
e.email = this.elem.elements.email.value;
}
return e;
}
} ]), e;
}();
i.delegateMixin(l.prototype), e.exports = l;
},
675: function(e, t) {
e.exports = {
client: {
choose_payment_method: "Choose payment method",
specify_company_name: "Specify company name",
error_start_again: "<p>#{message}</p><p>Please try purchase again.</p> <p>If you think that there is an error on server - contact with <a href='mailto:#{email}'> customer service</a>.</p>\n",
maybe_purchase_error: "<p>#{message}</p><p>If you think an error has occurred &mdash; please contact with <a href='mailto:#{email}'>customer service</a>.</p>\n",
purchase_error: "An error has occurred, please contact with <a href='mailto:#{email}'>customer service</a>.\n"
},
currency: "USD"
};
},
676: function(e, t) {
e.exports = {
client: {
choose_payment_method: "Выберите метод оплаты.",
specify_company_name: "Укажите название компании.",
error_start_again: "<p>#{message}</p><p>Please .</p> <p>Если вы считаете, что на сервере ошибка – свяжитесь со <a href='mailto:#{mail}'> службой поддержки</a>.</p>\n",
maybe_purchase_error: "<p>#{message}</p><p>Если вы считаете, что произошла ошибка &mdash; свяжитесь со <a href='mailto:#{email}'>службой поддержки</a>.</p>\n",
purchase_error: "Ошибка на сервере, свяжитесь со <a href='mailto:#{email}'>службой поддержки</a>.\n"
},
currency: "RUB"
};
},
678: function(e, t) {
e.exports = {
newOrder: {
title: "Buy EPUB/PDF for offline reading",
choose_course: "Which parts of the tutorial you want?",
price: "Price",
specifyEmail: "Specify your email",
note: "The download link will be sent to this address after payment.",
choose_payment: "Choose payment method",
continue: "Continue",
confirmation: "Confirmation",
currency: "USD",
continue_with_paypal: "Pay with PayPal"
},
orders: {
order: "Order",
failed: "Payment failed, please try again later.",
currency: "$",
payment: "Payment",
successful: "Successful",
pending: "Confirmation pending",
amount: "Price",
choose_another_payment: "Choose another payment method",
do_not_pay_twice: "Do not pay twice. Change payment method only if you are sure that payment failed.",
questions: "If you have any questions please send them to",
thanks: "Thanks for your purchase!",
confirmation_soon: "Confirmation will be sent to #{email}",
download_now: "You can download the tutorial right now using this link:"
},
client: {
enter_email: "Enter email."
},
onPaid: {
subject: "JavaScript Tutorial EPUB/PDF"
}
};
},
679: function(e, t) {
e.exports = {
newOrder: {
title: "Покупка учебника JavaScript",
choose_course: "Выберите курс",
price: "Стоимость",
specifyEmail: "Укажите свой email",
note: "После оплаты ссылка на скачивание учебника придет на этот адрес.",
choose_payment: "Выберите метод оплаты",
continue: "Продолжить",
confirmation: "Подтверждение",
currency: "RUB",
continue_with_paypal: "Оплатить через PayPal"
},
orders: {
order: "Заказ",
failed: "Оплата не прошла, попробуйте ещё раз.",
currency: "р.",
payment: "Оплата",
successful: "Осуществлена успешно",
pending: "Ожидается подтверждение",
amount: "Стоимость",
choose_another_payment: "Выберите другой метод оплаты",
do_not_pay_twice: "Не оплачивайте дважды. Меняйте метод оплаты лишь если уверены, что оплата не произошла.",
questions: "Если у вас возникли какие-либо вопросы, присылайте их на",
thanks: "Спасибо за покупку!",
confirmation_soon: "В ближайшее время на электронный адрес #{email} придёт подтверждение.",
download_now: "Вы можете скачать учебник прямо сейчас, по ссылке"
},
client: {
enter_email: "Введите email."
},
onPaid: {
subject: "Учебник для чтения оффлайн"
}
};
}
}, [ 23 ]);