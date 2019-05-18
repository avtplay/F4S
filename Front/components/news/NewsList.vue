<template>
  <div class="columns is-centered is-multiline">
    <div class="card column is-one-quarter" v-for="n in news" :key="n.id">
      <VmNews :news="n"></VmNews>
    </div>
    <div class="section" v-if="news.length === 0">
      <p>{{ noNewsLabel }}</p>
    </div>
  </div>
</template>

<script>
import VmNews from './News';
import { getByTitle } from '@/assets/filters';

export default {
  name: 'newsList',
  
  components: { VmNews },
  
  data () {
    return {
      id: '',
      noNewsLabel: 'aucune news trouvée'
    };
  },

  computed: {
    news () {
        console.log("test"+this.$store.state.news[1].id)
        return this.$store.state.news;
    }
  },

  methods: {
  }

};
</script>

<style lang="scss" scoped>
  .card {
    margin: 10px;
  }
</style>
