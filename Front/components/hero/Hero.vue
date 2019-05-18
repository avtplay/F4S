<template>
  <div class="hero is-medium is-bold">
    <div class="hero-body">
      <div class="container" v-if="this.$router.history.current.path === '/'">
        <h1 class="title has-text-centered">
          Des légumes frais chaque jours 
          <span/>
        </h1>
        <h2 class="subtitle has-text-centered">
          <a class="button is-success" @click="$router.push({ name: 'searchpage-shearchpage' })">envie de manger local ? </a>
        </h2>
      </div>
      <div class="container" v-if="this.$router.history.current.path == '/searchpage/shearchpage'">
        <h1 class="title has-text-centered">
          Que cherchez vous ?  
          <span/>
        </h1>
        <VmSearch></VmSearch>
      </div>
    </div>
  </div>
</template>
<script>
import VmSearch from '../search/Search';
export default {
  name: 'VmHero',

  mounted() {
    console.log(this.$router.history.current.path)
  },

  components: {
      VmSearch
    },
  
}
</script>


<style lang="scss" scoped>
    .hero {
      background-image: url("../../static/F4S/image_acceuil_1.jpg");
    }
    h1, h2 {
      color: #fff;
    }
</style>