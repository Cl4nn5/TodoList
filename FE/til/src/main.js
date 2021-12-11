import Vue from 'vue'
// import App from './App.vue'
import Index from './Index.vue'

Vue.config.productionTip = false

new Vue({
  render: h => h(Index),
}).$mount('#app')
